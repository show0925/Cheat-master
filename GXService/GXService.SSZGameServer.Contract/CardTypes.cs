﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using GXService.CardRecognize.Contract;

namespace GXService.SSZGameServer.CardTypeParseService.Contract
{
    //各种牌型的枚举
    public enum EmTypeCard
    {
        NoType, OnePair, DoublePair, ThreeSame, Straight, Flush, Gourd, Boom, StraightFlush
    }

    //牌型比较所处的位置：头墩、中墩、尾墩
    public enum EmRegionCompare
    {
        Head,
        Body,
        Tail
    }

    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class CardTypeResult
    {
        public CardTypeResult(CardType head, CardType middle, CardType tail)
        {
            CardTypeHead = head;
            CardTypeMiddle = middle;
            CardTypeTail = tail;
        }

        [DataMember]
        public CardType CardTypeHead { get; private set; }
        [DataMember]
        public CardType CardTypeMiddle { get; private set; }
        [DataMember]
        public CardType CardTypeTail { get; private set; }

        public int Compare(CardTypeResult c)
        {
            return CardTypeHead.Compare(c.CardTypeHead, EmRegionCompare.Head) +
                   CardTypeMiddle.Compare(c.CardTypeMiddle, EmRegionCompare.Body) +
                   CardTypeTail.Compare(c.CardTypeTail, EmRegionCompare.Tail);
        }
    }

    //牌型对象的基类
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    [KnownType(typeof(StraightFlushCardType))]
    [KnownType(typeof(FlushCardType))]
    [KnownType(typeof(StraightCardType))]
    [KnownType(typeof(BoomCardType))]
    [KnownType(typeof(GourdCardType))]
    [KnownType(typeof(ThreeSameCardType))]
    [KnownType(typeof(DoublePairCardType))]
    [KnownType(typeof(OnePairCardType))]
    [KnownType(typeof(NoTypeCardType))]
    [KnownType(typeof(ThreeSameInHeadCardType))]
    [KnownType(typeof(PairInHeadCardType))]
    [KnownType(typeof(NoTypeInHeadCardType))]
    public abstract class CardType
    {
        [DataMember]
        protected List<Card> Cards;

        [DataMember]
        protected EmTypeCard CardTypeEm;

        public int Compare(CardType c, EmRegionCompare r)
        {
            var ret = CompareTypeRule(c);
            if (ret == 0)
            {
                ret = CompareWithSameType(c);
            }

            switch (r)
            {
                case EmRegionCompare.Head:
                    ret *= (ret < 0 ? c.GetHeadPoint() : GetHeadPoint());
                    break;

                case EmRegionCompare.Body:
                    ret *= (ret < 0 ? c.GetBodyPoint() : GetBodyPoint());
                    break;

                case EmRegionCompare.Tail:
                    ret *= (ret < 0 ? c.GetTailPoint() : GetTailPoint());
                    break;
            }

            return ret;
        }

        public int CompareTypeRule(CardType c)
        {
            var ret = 0;

            if (GetCardEmType() > c.GetCardEmType())
            {
                ret = 1;
            }
            else if (GetCardEmType() < c.GetCardEmType())
            {
                ret = -1;
            }

            return ret;
        }

        public List<Card> GetCards()
        {
            return Cards.ToList();
        }

        public EmTypeCard GetCardEmType()
        {
            return CardTypeEm;
        }

        protected abstract int CompareWithSameType(CardType c);

        protected abstract int GetHeadPoint();

        protected abstract int GetBodyPoint();

        protected abstract int GetTailPoint();
    }

    #region 中墩/尾墩牌型
    //同花顺牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class StraightFlushCardType : CardType
    {
        protected const int BodyPoint = 10;
        protected const int TailPoint = 5;

        public StraightFlushCardType(List<Card> cards)
        {
            //根据牌值大小进行排序
            cards.Sort((card, card1) => card.Num == card1.Num ? 0 : (card.Num > card1.Num ? 1 : -1));
            if (cards[0].Num == CardNum._A && cards[1].Num == CardNum._5)
            {
                cards.Add(cards[0]);
                cards.RemoveAt(0);
            }
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.StraightFlush;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as StraightFlushCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? (Cards[0].Color == ct.Cards[0].Color
                              ? 0
                              : (Cards[0].Color > ct.Cards[0].Color
                                     ? 1
                                     : -1))
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //同花牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class FlushCardType : CardType
    {
        protected const int BodyPoint = 1;
        protected const int TailPoint = 1;

        public FlushCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.Flush;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as FlushCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Color == ct.Cards[0].Color
                       ? 0
                       : (Cards[0].Color > ct.Cards[0].Color
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //杂顺牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class StraightCardType : CardType
    {
        protected const int BodyPoint = 1;
        protected const int TailPoint = 1;

        public StraightCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.Straight;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as StraightCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //炸弹牌型(4+1)
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class BoomCardType : CardType
    {
        protected const int BodyPoint = 8;
        protected const int TailPoint = 4;

        public BoomCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.Boom;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as BoomCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //葫芦牌型(3+2)
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class GourdCardType : CardType
    {
        protected const int BodyPoint = 2;
        protected const int TailPoint = 2;

        public GourdCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.Gourd;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as GourdCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //3+1+1牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class ThreeSameCardType : CardType
    {
        protected const int BodyPoint = 1;
        protected const int TailPoint = 1;

        public ThreeSameCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.ThreeSame;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as ThreeSameCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //2+2+1牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class DoublePairCardType : CardType
    {
        protected const int BodyPoint = 1;
        protected const int TailPoint = 1;

        public DoublePairCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.DoublePair;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as DoublePairCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? (Cards[2].Num == ct.Cards[2].Num
                              ? 0
                              : (Cards[2].Num > ct.Cards[2].Num
                                     ? 1
                                     : -1))
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //2+1+1+1牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class OnePairCardType : CardType
    {
        protected const int BodyPoint = 1;
        protected const int TailPoint = 1;

        public OnePairCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.OnePair;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as OnePairCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }

    //1+1+1+1+1牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class NoTypeCardType : CardType
    {
        protected const int BodyPoint = 1;
        protected const int TailPoint = 1;

        public NoTypeCardType(List<Card> cards)
        {
            cards.Sort((card, card1) => card.Num == card1.Num ? 0 : (card.Num > card1.Num ? -1 : 1));
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.NoType;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as NoTypeCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            throw new InvalidDataException("此牌型不能放在头墩");
        }

        protected override int GetBodyPoint()
        {
            return BodyPoint;
        }

        protected override int GetTailPoint()
        {
            return TailPoint;
        }
    }
    #endregion

    #region 头墩牌型
    //冲3牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class ThreeSameInHeadCardType : CardType
    {
        protected const int HeadPoint = 3;

        public ThreeSameInHeadCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.ThreeSame;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as ThreeSameInHeadCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            return HeadPoint;
        }

        protected override int GetBodyPoint()
        {
            throw new InvalidDataException("此牌型不能放在中墩");
        }

        protected override int GetTailPoint()
        {
            throw new InvalidDataException("此牌型不能放在尾墩");
        }
    }

    //一对牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class PairInHeadCardType : CardType
    {
        protected const int HeadPoint = 1;

        public PairInHeadCardType(IEnumerable<Card> cards)
        {
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.OnePair;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as PairInHeadCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            return HeadPoint;
        }

        protected override int GetBodyPoint()
        {
            throw new InvalidDataException("此牌型不能放在中墩");
        }

        protected override int GetTailPoint()
        {
            throw new InvalidDataException("此牌型不能放在尾墩");
        }
    }

    //1+1+1牌型
    [DataContract(Namespace = "GXService.CardRecognize.Contract")]
    public class NoTypeInHeadCardType : CardType
    {
        protected const int HeadPoint = 1;

        public NoTypeInHeadCardType(List<Card> cards)
        {
            cards.Sort((card, card1) => card.Num == card1.Num ? 0 : (card.Num > card1.Num ? -1 : 1));
            Cards = cards.ToList();

            CardTypeEm = EmTypeCard.NoType;
        }

        protected override int CompareWithSameType(CardType c)
        {
            var ct = c as NoTypeInHeadCardType;
            if (ct == null)
            {
                throw new InvalidDataException("牌型对象不相同");
            }

            return Cards[0].Num == ct.Cards[0].Num
                       ? 0
                       : (Cards[0].Num > ct.Cards[0].Num
                              ? 1
                              : -1);
        }

        protected override int GetHeadPoint()
        {
            return HeadPoint;
        }

        protected override int GetBodyPoint()
        {
            throw new InvalidDataException("此牌型不能放在中墩");
        }

        protected override int GetTailPoint()
        {
            throw new InvalidDataException("此牌型不能放在尾墩");
        }
    }

    public class HeadCardTypeFactory
    {
        protected static HeadCardTypeFactory Singleton = new HeadCardTypeFactory();

        protected HeadCardTypeFactory()
        { }

        public static HeadCardTypeFactory GetSingleton()
        {
            return Singleton;
        }

        public CardType GetHeadCardType(List<Card> cards)
        {
            if (cards[0].Num == cards[1].Num && cards[0].Num == cards[2].Num && cards[1].Num == cards[2].Num)
            {
                return new ThreeSameInHeadCardType(cards);
            }

            if (cards[0].Num != cards[1].Num && cards[0].Num != cards[2].Num && cards[1].Num != cards[2].Num)
            {
                return new NoTypeInHeadCardType(cards);
            }

            return new PairInHeadCardType(cards);
        }
    }
    #endregion
}
