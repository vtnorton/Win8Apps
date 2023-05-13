using Mcg.System;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;



namespace __InterfaceProxies
{
	public class ServiceChannelProxy_service_readSoap : global::System.ServiceModel.Channels.ServiceChannelProxy_P, global::SunApp.Read.service_readSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::SunApp.Read.ReadEmployeeResponse_P> global::SunApp.Read.service_readSoap_P.ReadEmployeeAsync(global::SunApp.Read.ReadEmployeeRequest_P request)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::SunApp.Read.service_readSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					request
			};
			global::System.Threading.Tasks.Task_P<global::SunApp.Read.ReadEmployeeResponse_P> retval = ((global::System.Threading.Tasks.Task_P<global::SunApp.Read.ReadEmployeeResponse_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	public class ServiceChannelProxy_add_employeeSoap : global::System.ServiceModel.Channels.ServiceChannelProxy_P, global::SunApp.AddEmployee.add_employeeSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::SunApp.AddEmployee.AddEmployeeResponse_P> global::SunApp.AddEmployee.add_employeeSoap_P.AddEmployeeAsync(global::SunApp.AddEmployee.AddEmployeeRequest_P request)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(global::SunApp.AddEmployee.add_employeeSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					request
			};
			global::System.Threading.Tasks.Task_P<global::SunApp.AddEmployee.AddEmployeeResponse_P> retval = ((global::System.Threading.Tasks.Task_P<global::SunApp.AddEmployee.AddEmployeeResponse_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	[global::System.Runtime.CompilerServices.EagerStaticClassConstruction]
	[global::System.Runtime.CompilerServices.DependencyReductionRoot]
	public static class __DispatchProxyImplementationData
	{
		static global::System.Reflection.DispatchProxyEntry[] s_entryTable = new global::System.Reflection.DispatchProxyEntry[] {
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(global::System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(global::SunApp.Read.service_readSoap_P).TypeHandle,
					ImplementationClassType = typeof(global::__InterfaceProxies.ServiceChannelProxy_service_readSoap).TypeHandle,
				}, 
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(global::System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(global::SunApp.AddEmployee.add_employeeSoap_P).TypeHandle,
					ImplementationClassType = typeof(global::__InterfaceProxies.ServiceChannelProxy_add_employeeSoap).TypeHandle,
				}
		};
		static __DispatchProxyImplementationData()
		{
			global::System.Reflection.DispatchProxyHelpers.RegisterImplementations(s_entryTable);
		}
	}
}

namespace SunApp.Read
{
	[global::System.Runtime.InteropServices.McgRedirectedType("SunApp.Read.service_readSoap, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public interface service_readSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::SunApp.Read.ReadEmployeeResponse_P> ReadEmployeeAsync(global::SunApp.Read.ReadEmployeeRequest_P request);
	}
}

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Reflection.DispatchProxy, System.Private.Interop, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class DispatchProxy_P
	{
	}
}

namespace System.ServiceModel.Channels
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.ServiceModel.Channels.ServiceChannelProxy, System.Private.ServiceModel, Version=4.0.0.0, Culture=neutral," +
		" PublicKeyToken=b03f5f7f11d50a3a")]
	public class ServiceChannelProxy_P : global::System.Reflection.DispatchProxy
	{
		protected override object Invoke(
					global::System.Reflection.MethodInfo targetMethodInfo, 
					object[] args)
		{
			return null;
		}
	}
}

namespace SunApp.Read
{
	[global::System.Runtime.InteropServices.McgRedirectedType("SunApp.Read.ReadEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class ReadEmployeeResponse_P
	{
	}
}

namespace System.Threading.Tasks
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Threading.Tasks.Task`1, System.Private.Threading, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f" +
		"7f11d50a3a")]
	public class Task_P<TResult>
	{
	}
}

namespace SunApp.Read
{
	[global::System.Runtime.InteropServices.McgRedirectedType("SunApp.Read.ReadEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class ReadEmployeeRequest_P
	{
	}
}

namespace SunApp.AddEmployee
{
	[global::System.Runtime.InteropServices.McgRedirectedType("SunApp.AddEmployee.add_employeeSoap, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public interface add_employeeSoap_P
	{
		global::System.Threading.Tasks.Task_P<global::SunApp.AddEmployee.AddEmployeeResponse_P> AddEmployeeAsync(global::SunApp.AddEmployee.AddEmployeeRequest_P request);
	}
}

namespace SunApp.AddEmployee
{
	[global::System.Runtime.InteropServices.McgRedirectedType("SunApp.AddEmployee.AddEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class AddEmployeeResponse_P
	{
	}
}

namespace SunApp.AddEmployee
{
	[global::System.Runtime.InteropServices.McgRedirectedType("SunApp.AddEmployee.AddEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class AddEmployeeRequest_P
	{
	}
}
