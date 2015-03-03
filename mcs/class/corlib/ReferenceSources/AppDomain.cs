using System.Reflection;
using System.Security;
using System.Runtime.Versioning;

namespace System {

	public partial class AppDomain
	{
		internal String GetTargetFrameworkName()
		{
			return ".NETFramework,Version=v4.5";
		}

		internal static bool IsAppXModel ()
		{
			return false;
		}

		internal static bool IsAppXDesignMode ()
		{
			return false;
		}
	}
}