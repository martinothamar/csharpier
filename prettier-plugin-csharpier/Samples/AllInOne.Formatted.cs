using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Math;
using System.Diagnostics;
using ConsoleApplication2.Test;
using int1;
using ABC.X<int>;
using System.Math;
using System.DayOfWeek;
using System.Linq.Enumerable;

class TopLevelType : IDisposable
{
    void Dispose() { }
}

namespace My
{
    using A.B;
    interface CoContra { }


    public unsafe partial class A : C,
    I
    {
        static extern bool CreateDirectory(string name, SecurityAttribute sa);

        private const int global = ;

        static A() { }
        public A(int foo)
        {

            int? local = int.MaxValue;
            Guid? local0 = new Guid(r.ToString());

            var ?????? = local;
            var ??? = local;
            var local3 = 0local4 = 1;
            local3 = local4 = 1;
            var local5 = null as Action ?? null;
            var local6 = local5 is Action;

            var u = 1u;
            var U = 1U;
            long hex = 0xBADC0DEHex = 0XDEADBEEFl = L = 1Ll2 = 2l;
            ulong ul = 1ulUl = 1UluL = 1uLUL = 1ULlu = 1luLu = 1LulU = 1lULU = 1LU;
            int minInt32Value = ;
            int minInt64Value = ;

            bool @bool;
            byte @byte;
            char @char = 'c'\u0066 = '\u0066'hexchar = '\x0130'hexchar2 = ;
            string \U00000065 = "\U00000065";
            decimal @decimal = 1.44M;
            @decimal = 1.2m;
            dynamic @dynamic;
            double @double = M.PI;
            @double = 1d;
            @double = 1D;
            @double = ;
            float @float = 1.2f;
            @float = 1.44F;
            int @int = local ?? ;
            long @long;
            object @object;
            sbyte @sbyte;
            short @short;
            string @string = @"""/*";
            uint @uint;
            ulong @ulong;
            ushort @ushort;

            dynamic dynamic = local5;
            var add = 0;
            var alias = 0;
            var arglist = 0;
            var ascending = 0;
            var async = 0;
            var await = 0;
            var by = 0;
            var descending = 0;
            var dynamic = 0;
            var equals = 0;
            var from = 0;
            var get = 0;
            var group = 0;
            var into = 0;
            var join = 0;
            var let = 0;
            var nameof = 0;
            var on = 0;
            var orderby = 0;
            var partial = 0;
            var remove = 0;
            var select = 0;
            var set = 0;
            var when = 0;
            var where = 0;
            var yield = 0;
            var __ = 0;
            where = yield = 0;

            if (i > 0)
            {
                return;
            }
            else if (i == 0)
            {

            }
            var o1 = new MyObject();
            var o2 = new MyObject(var);
            var o3 = new MyObject { A = i };
            var o4 = new MyObject(@dynamic) { A = 0, B = 0, C = 0 };
            var o5 = new { A = 0 };
            var dictionaryInitializer = new Dictionary<int, string> { ,  };
             a = ;
             cube = ;
             jagged = ;
             arr = ;
            arr[0] = ;
            arr[0][0, 0] = 47;
             arrayTypeInference = ;
            switch (3) { }
            switch (i)
            {
                case 0:
                case 1:
                {
                    goto case 2;
                }
                case 2 + 3:
                {
                    goto default;
                    break;
                }
                default:
                {
                    return;
                }
            }
            test




            foreach (var i in Items())
            {
                if (i == 7)return;
                else continue;
            }










            var anonymous = ;
            var query = ;
            query = ;
        }

        private readonly int f1;
        private volatile int f2;
        public void Handler(object value) { }
        public int m(T t)
        {
            .m(t);
            return 1;
        }
        public string P
        {
            get { return "A"; }
            set;
        }
        public abstract string P { get; }






        class C { }
    }

    public interface I
    {
        void A(int value);

        string Value { get; set; }

        unsafe void UpdateSignatureByHashingContent( buffer, int size);
    }


    namespace Test
    {
        using System;
        using System.Collections;
        public class ??????
        {
            public static IEnumerable Power(int number, int exponent)
            {
                ?????? ?????? = new ??????();
                ??????.Main();
                int counter = (0 + 0);
                int ??? = 0;
                test
            }
            static void Main()
            {
                foreach (int i in Power(2, 8))
                {
                    Console.Write("{0} ", i);
                }
            }
            async void Wait()
            {
                ;
            }
            void AsyncAnonymous()
            {
                var task = Task.Factory.StartNew(() => );
            }
        }
    }
}

namespace ConsoleApplication1
{
    namespace RecursiveGenericBaseType
    {
        class A : B<A<T>, A<T>>
        {
            protected virtual A<T> M() { }
            protected abstract B<A<T>, A<T>> N() { }
            static B<A<T>, A<T>> O() { }
        }

        sealed class B : A<B<T1, T2>>
        {
            protected override A<T> M() { }
            protected sealed override B<A<T>, A<T>> N() { }
            new static A<T> O() { }
        }
    }

    namespace Boo
    {
        public class Bar
        {
            public T f;
            public class Foo : IEnumerable<T>
            {
                public void Method(K k, T t, U u)
                {
                    A<int> a;
                    M(A<B, C>(5));
                }
            }
        }
    }

    class Test
    {
        void Bar3()
        {
            var x = new Boo.Bar<int>.Foo<object>();
            x.Method<string, string>(" ", 5, new object());

            var q = ;
        }



        public int foo = 5;
        void Bar2()
        {
            foo = 6;
            this.Foo = 5.GetType();
            Test t = "sss";
        }


        void Blah()
        {
            int i = 5;
            int? j = 6;

            Expression<Func<int>> e = () => i;
            Expression<Func<bool, Action>> e2 = b => () => ;
            Func<bool, bool> f = ;
            Func<int, int, int> f2 = () => 0;
            f2 = () => 1;
            Action a = Blah;
            f2 = () => ;
            f2 = () => ;
        }



        public Type Foo
        {
            get { var result = ; var t =  == ; t = ; return ; }
            set { var t = ; t.ToString(); t = value; }
        }

        public void Constants()
        {
            int i = 1 + 2 + 3 + 5;
            .String s = "a" +  + "a" + "a" + "a" + "A";
        }

        public void ConstructedType()
        {
            List<int> i = null;
            int c = i.Count;
        }
    }
}

namespace Comments.XmlComments.UndocumentedKeywords
{
    class C
    {
        void M(T t, U u)
        {

            int intValue = 0;
            intValue = intValue + 1;
            string strValue = "hello";
            MyClass c = new MyClass();
            string verbatimStr = @"\\\\";
        }
    }
    //General Test F. Type a very long class name, verify colorization happens correctly only upto the correct size (118324)

    class TestClassXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX { }

    class TestClassXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX22 { }

    class yield
    {
        void Foo(__arglist)
        {
            C<U> c = null;
            c.M<int>(5, );
            TypedReference tr = ;
            Type t = ;
            int j = ;
            Params(t, t);
            Params(ref c, out c);
        }
        void Params(dynamic a, dynamic b,  c) { }
        void Params(dynamic a, dynamic c,  c) { }

        public override string ToString()
        {
            return .ToString();
        }

        public partial void OnError();

        public partial void method()
        {
             a = ;
             var = ;
            int i = a[i];
            Foo<T> f = new Foo<int>();
            f.method();
            i = ;
            bool b = ;
            b = !b;
            i = ;
            b = i < i && i > i;
            int? ii = 5;
            int f = true ? 1 : 0;
            ;
            ;
            b = true && false || true;
            ;
            ;
            b = i == i && i != i && i <= i && ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            ;
            object s = x => x + 1;
            double d = .3;
            Point point;

             br = null;
            x[1] = 3;
            x[1, 5] = "str";
        }

    }
    // From here:https://github.com/dotnet/roslyn/wiki/New-Language-Features-in-C%23-6

    class CSharp6Features
    {

        public string First
        {
            get;
            set;
        }
        public string Last { get; set; }

        public string Third
        {
            get;
        }
        public string Fourth { get; }

        public Point Move(int dx, int dy);


        public void Print();

        public string Name
        => First + " " + Last;


        async void Test()
        {

            WriteLine(Sqrt( + ));
            WriteLine();
            var range = Range(5, 17);
            var even = range.Where(i =>  == 0);

            int? length = customers?.Length;
            Customer first = customers?;
            int length = customers?.Length ?? 0;
            int? first = customers??.Orders?.Count();
            PropertyChanged?.Invoke(this, args);

            string s = $"{p.Name} is {p.Age} year{{s}} old #";
            s = $"{p.Name} is \"{p.Age} year{(p.Age == 1 ? "" : "s")} old";
            s = $"{(p.Age == 2 ? $"{new Person { }}" : "")}";
            s = $@"\{p.Name}
                                   ""\";
            s = $"Color [ R={func(3)}, G={G}, B={B}, A={A} ]";

            if (x == null)
            WriteLine(nameof(person.Address.ZipCode));

            var numbers = new Dictionary<int, string>
            {
                 = "seven",
                 = "nine",
                 = "thirteen"
            };


            Resource res = null;

        }
    }
}

class CSharp70
{
    void PatternMatching(string arg, int b)
    {
        switch (arg)
        {


            default:break;
        }
         = e;

        if () { }

        if ()
        {
            Hello();
        }
    }

    public static async Task LocalFunctions( args)
    {
        string Hello2(int i)
        {
            return args[i];
        }

        async Task<string> Hello(T i);
        ;
    }

    public static void OutVar( args)
    {
        int.TryParse(Hello(1), out var item);
        int.TryParse(Hello(1), out int item);
    }

    public void ThrowExpression()
    {
        var result = nullableResult ?? ;
    }

    public void BinaryLiterals()
    {
        int nineteen = 0b10011;
    }

    public void DigitSeparators()
    {
        int bin = 0b1001_1010_0001_0100;
        int hex = 0x1b_a0_44_fe;
        int dec = 33_554_432;
        int weird = 1_2__3___4____5_____6______7_______8________9;
        double real = 1_000.111_1e-1_000;
    }
}

class CSharp71
{
    void DefaultWithoutTypeName(string content)
    {
        DefaultWithoutTypeName();
    }

    void TupleRecognize(int a,  b, ? c)
    {
        var result = list.Select(c => ).Where(t => t.f2 == 1);
    }
}

class CSharp72
{



    public void DoSomething(bool isEmployed, string personName, int personAge)
    { }

    public void NonTrailingNamedArguments()
    {
        DoSomething(true, name, age);
        DoSomething(true, name, age);
        DoSomething(name, true, age);
        DoSomething(name, age, true);
        DoSomething(true, age, name);
    }

    public void ConditionalRef()
    {
         r = ;
    }

    public void LeadingSeparator()
    {
        var res = 0 + 123 + 1_2_3 + 0x1_2_3 + 0b101 + 0b1_0_1
        + 0x_1_2 + 0b_1_0_1;
    }
}

class CSharp73
{
    void Blittable(T value)
    {
        var unmanaged = 666;
    }


    static IndexingMovableFixed s;

    public unsafe void IndexingMovableFixedFields()
    {
         ptr = s.myFixedField;
        int t = s.myFixedField[5];
    }

    public void PatternBasedFixed()
    {

    }

    public void StackallocArrayInitializer()
    {
        Span<int> a = ;
        Span<int> a = ;
        Span<int> a = ;
        Span<int> a = ;
    }

    public void TupleEquality()
    {
         t1t2;
        var res = t1 == ;
    }
}

namespace CSharp80
{
    class CSharp80ExceptInterfaceDefaultImplement
    {
        void ReferenceNullable()
        {
            var? x = E;
            .ToString();
            string? wtf = null;
            ? hello;
        }

        void Patterns()
        {
            if ()Do();

            return ;

            var newState = ;
        }

        async Task AsyncStreams()
        {
            foreach (var item in asyncEnumerables) { }
        }

        void Ranges()
        {
            var thirdItem = list[2];
            var lastItem = list[];
            var multiDimensional = list[3, ];

            var slice1 = list[];
            var slice2 = list[];
            var slice3 = list[];
            var slice4 = list[];
            var multiDimensional = list[, ];
        }

        void UsingDeclarators()
        {
            var item = new FileStream("./.f");

            item.Dispose();
        }

        void StaticLocalFunction()
        {
            static unsafe void Func1() { }
            static unsafe void Func1() { }
            async static void Func2() { }
            static async void Func2() { }
        }

        void NullCoalescingAssignment()
        {
            var item = ;
        }

        public readonly float Hello()
        {
            return 0.1f;
        }
    }
    interface IA
    {
        void M()
        {
            WriteLine("IA.M");
        }
    }
    interface IA
    {
        void M()
        {
            WriteLine("IA.M");
        }
    }
    interface IB : IA
    {
        override void M()
        {
            WriteLine("IB.M");
        }
    }
    interface IC : IA
    {
        override void M()
        {
            WriteLine("IC.M");
        }
    }
}