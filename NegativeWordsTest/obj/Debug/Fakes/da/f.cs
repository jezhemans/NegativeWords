// <assemblyHash>e3f168ae</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=11.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias da;
extern alias mqttf;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("DataAccess", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("DataAccess")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace DataAccess.Fakes
{
    /// <summary>Shim type of DataAccess.Words</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(da::DataAccess.Words))]
    [global::System.Diagnostics.DebuggerDisplay("Shim of Words")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimWords
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<da::DataAccess.Words>
    {
        /// <summary>Initializes a new shim instance</summary>
        public ShimWords()
        : base()
        {
        }

        /// <summary>Initializes a new shim for the given instance</summary>
        public ShimWords(da::DataAccess.Words instance)
        : base(instance)
        {
        }

        /// <summary>Define shims for all instances members</summary>
        public static partial class AllInstances
        {
            /// <summary>Sets the shim of Words.GetNegativeWords()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<da::DataAccess.Words, global::System.Collections.Generic.List<da::DataAccess.Words>> GetNegativeWords
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetNegativeWords", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(da::DataAccess.Words), (object)null, 
                         "GetNegativeWords", typeof(global::System.Collections.Generic.List<da::DataAccess.Words>), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of Words.get_Word()</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<da::DataAccess.Words, string> WordGet
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_Word", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(da::DataAccess.Words), (object)null, "get_Word", typeof(string), new global::System.Type[]{});
                }
            }

            /// <summary>Sets the shim of Words.set_Word(String value)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<da::DataAccess.Words, string> WordSetString
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("set_Word", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(da::DataAccess.Words), (object)null, 
                         "set_Word", typeof(void), new global::System.Type[]{typeof(string)});
                }
            }
        }

        /// <summary>Assigns the &apos;Current&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsCurrent()
        {
            global::DataAccess.Fakes.ShimWords.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Assigns the &apos;NotImplemented&apos; behavior for all methods of the shimmed type</summary>
        public static void BehaveAsNotImplemented()
        {
            global::DataAccess.Fakes.ShimWords.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Assigns the behavior for all methods of the shimmed type</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(da::DataAccess.Words), value);
            }
        }

        /// <summary>Binds the members of the interface to the shim.</summary>
        public global::DataAccess.Fakes.ShimWords Bind(da::DataAccess.INegativeWords target)
        {
            if (target == (da::DataAccess.INegativeWords)null)
              throw new global::System.ArgumentNullException("target");
            mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime
              .Bind<da::DataAccess.Words, global::DataAccess.Fakes.ShimWords, da::DataAccess.INegativeWords>(this, target);
            return this;
        }

        /// <summary>Sets the shim of Words.Words()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<da::DataAccess.Words> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(da::DataAccess.Words), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Words.Words(String word)</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<da::DataAccess.Words, string> ConstructorString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(da::DataAccess.Words), (object)null, 
                     ".ctor", typeof(void), new global::System.Type[]{typeof(string)});
            }
        }

        /// <summary>Sets the shim of Words.GetNegativeWords()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.Generic.List<da::DataAccess.Words>> GetNegativeWords
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("GetNegativeWords", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions
                                                 .Uncurrify<da::DataAccess.Words, global::System.Collections.Generic.List<da::DataAccess.Words>>(value)), 
                     typeof(da::DataAccess.Words), base.Instance, 
                     "GetNegativeWords", typeof(global::System.Collections.Generic.List<da::DataAccess.Words>), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Words.get_Word()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<string> WordGet
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_Word", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<da::DataAccess.Words, string>(value)), 
                     typeof(da::DataAccess.Words), base.Instance, "get_Word", typeof(string), new global::System.Type[]{});
            }
        }

        /// <summary>Sets the shim of Words.set_Word(String value)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<string> WordSetString
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("set_Word", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<da::DataAccess.Words, string>(value)), 
                     typeof(da::DataAccess.Words), base.Instance, "set_Word", typeof(void), new global::System.Type[]{typeof(string)});
            }
        }
    }
}
namespace DataAccess.Fakes
{
    /// <summary>Stub type of DataAccess.INegativeWords</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(da::DataAccess.INegativeWords))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of INegativeWords")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubINegativeWords
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase<da::DataAccess.INegativeWords>
      , da::DataAccess.INegativeWords
    {
        /// <summary>Initializes a new instance of type StubINegativeWords</summary>
        public StubINegativeWords()
        {
        }

        /// <summary>Sets the stub of INegativeWords.GetNegativeWords()</summary>
        global::System.Collections.Generic.List<da::DataAccess.Words> da::DataAccess.INegativeWords.GetNegativeWords()
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.Generic.List<da::DataAccess.Words>> 
                ___currentMethod = ((da::DataAccess.INegativeWords)this).GetNegativeWords;
              ___observer.Enter(typeof(da::DataAccess.INegativeWords), (global::System.Delegate)___currentMethod);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.Generic.List<da::DataAccess.Words>> ___sh
               = this.GetNegativeWords;
            if ((object)___sh != (object)null)
              return ___sh.Invoke();
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::DataAccess.Fakes.StubINegativeWords, global::System.Collections.Generic.List<da::DataAccess.Words>>
                         (this, "DataAccess.INegativeWords.GetNegativeWords");
            }
        }

        /// <summary>Sets the stub of INegativeWords.GetNegativeWords()</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<global::System.Collections.Generic.List<da::DataAccess.Words>> GetNegativeWords;
    }
}
namespace DataAccess.Fakes
{
    /// <summary>Stub type of DataAccess.Words</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(da::DataAccess.Words))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of Words")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubWords
      : da::DataAccess.Words
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<da::DataAccess.Words>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Initializes a new instance</summary>
        public StubWords()
        {
            this.InitializeStub();
        }

        /// <summary>Initializes a new instance</summary>
        public StubWords(string word)
        : base(word)
        {
            this.InitializeStub();
        }

        /// <summary>Gets or sets a value that indicates if the base method should be called instead of the fallback behavior</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Initializes a new instance of type StubWords</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Gets or sets the instance behavior.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Gets or sets the instance observer.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
