﻿using System.Reflection;
using System.Runtime.InteropServices;
using ZeyrekFramework.Core.Aspects.Postsharp.ExceptionAspects;
using ZeyrekFramework.Core.Aspects.Postsharp.LogAspects;
using ZeyrekFramework.Core.Aspects.Postsharp.PerformanceAspects;
using ZeyrekFramework.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ZeyrekFramework.Business")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("ZeyrekFramework.Business")]
[assembly: AssemblyCopyright("Copyright ©  2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
//[assembly: LogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "ZeyrekFramework.Business.Concrete.Managers.*")]
[assembly: LogAspect(typeof(FileLogger), AttributeTargetTypes = "ZeyrekFramework.Business.Concrete.Managers.*")]
//[assembly: ExceptionLogAspect(typeof(DatabaseLogger), AttributeTargetTypes = "ZeyrekFramework.Business.Concrete.Managers.*")]
[assembly: ExceptionLogAspect(typeof(FileLogger), AttributeTargetTypes = "ZeyrekFramework.Business.Concrete.Managers.*")]
[assembly: PerformanceCounterAspect(AttributeTargetTypes = "ZeyrekFramework.Business.Concrete.Managers.*")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3463fa83-ad2f-4f35-9bf5-85bb594083f3")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
