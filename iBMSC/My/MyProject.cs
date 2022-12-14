using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace iBMSC.My;

[StandardModule]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal sealed class MyForms
    {
        public AboutBox1 m_AboutBox1;

        public ColorPicker m_ColorPicker;

        public dgMyO2 m_dgMyO2;

        public MainWindow m_MainWindow;

        public SplashScreen1 m_SplashScreen1;

        [ThreadStatic]
        private static Hashtable m_FormBeingCreated;

        public AboutBox1 AboutBox1
        {
            get
            {
                m_AboutBox1 = Create__Instance__(m_AboutBox1);
                return m_AboutBox1;
            }
            set
            {
                if (value != m_AboutBox1)
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    Dispose__Instance__(ref m_AboutBox1);
                }
            }
        }

        public ColorPicker ColorPicker
        {
            get
            {
                m_ColorPicker = Create__Instance__(m_ColorPicker);
                return m_ColorPicker;
            }
            set
            {
                if (value != m_ColorPicker)
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    Dispose__Instance__(ref m_ColorPicker);
                }
            }
        }

        public dgMyO2 dgMyO2
        {
            get
            {
                m_dgMyO2 = Create__Instance__(m_dgMyO2);
                return m_dgMyO2;
            }
            set
            {
                if (value != m_dgMyO2)
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    Dispose__Instance__(ref m_dgMyO2);
                }
            }
        }

        public MainWindow MainWindow
        {
            get
            {
                m_MainWindow = Create__Instance__(m_MainWindow);
                return m_MainWindow;
            }
            set
            {
                if (value != m_MainWindow)
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    Dispose__Instance__(ref m_MainWindow);
                }
            }
        }

        public SplashScreen1 SplashScreen1
        {
            get
            {
                m_SplashScreen1 = Create__Instance__(m_SplashScreen1);
                return m_SplashScreen1;
            }
            set
            {
                if (value != m_SplashScreen1)
                {
                    if (value != null)
                    {
                        throw new ArgumentException("Property can only be set to Nothing");
                    }
                    Dispose__Instance__(ref m_SplashScreen1);
                }
            }
        }

        [DebuggerHidden]
        private static T Create__Instance__<T>(T Instance) where T : Form, new()
        {
            //Discarded unreachable code: IL_00dc
            if (Instance == null || Instance.IsDisposed)
            {
                if (m_FormBeingCreated != null)
                {
                    if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
                    }
                }
                else
                {
                    m_FormBeingCreated = new Hashtable();
                }
                m_FormBeingCreated.Add(typeof(T), null);
                try
                {
                    return new T();
                }
                catch (TargetInvocationException ex) when (((Func<bool>)delegate
                {
                    // Could not convert BlockContainer to single expression
                    ProjectData.SetProjectError(ex);
                    return ex.InnerException != null;
                }).Invoke())
                {
                    string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
                    throw new InvalidOperationException(resourceString, ex.InnerException);
                }
                finally
                {
                    m_FormBeingCreated.Remove(typeof(T));
                }
            }
            return Instance;
        }

        [DebuggerHidden]
        private void Dispose__Instance__<T>(ref T instance) where T : Form
        {
            instance.Dispose();
            instance = null;
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public MyForms()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object o)
        {
            return base.Equals(RuntimeHelpers.GetObjectValue(o));
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        internal new Type GetType()
        {
            return typeof(MyForms);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object o)
        {
            return base.Equals(RuntimeHelpers.GetObjectValue(o));
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerHidden]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal new Type GetType()
        {
            return typeof(MyWebServices);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [DebuggerHidden]
        public override string ToString()
        {
            return base.ToString();
        }

        [DebuggerHidden]
        private static T Create__Instance__<T>(T instance) where T : new()
        {
            if (instance == null)
            {
                return new T();
            }
            return instance;
        }

        [DebuggerHidden]
        private void Dispose__Instance__<T>(ref T instance)
        {
            instance = default(T);
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public MyWebServices()
        {
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
        [CompilerGenerated]
        [ThreadStatic]
        private static T m_ThreadStaticValue;

        internal T GetInstance
        {
            [DebuggerHidden]
            get
            {
                if (m_ThreadStaticValue == null)
                {
                    m_ThreadStaticValue = new T();
                }
                return m_ThreadStaticValue;
            }
        }

        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ThreadSafeObjectProvider()
        {
        }
    }

    private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

    private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

    private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

    private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

    private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
        [DebuggerHidden]
        get => m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
        [DebuggerHidden]
        get => m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
        [DebuggerHidden]
        get => m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyForms Forms
    {
        [DebuggerHidden]
        get => m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyWebServices WebServices
    {
        [DebuggerHidden]
        get => m_MyWebServicesObjectProvider.GetInstance;
    }
}
