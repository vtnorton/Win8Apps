using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
        }
        static int[] s_knownContractsLists = new int[] {
              -1,   41,   -1,   41,   -1, }
        ;
        // Count = 219
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                5, // array length: 5
                699, // index: 699, string: "HelpLink"
                708, // index: 708, string: "InnerException"
                723, // index: 723, string: "Message"
                731, // index: 731, string: "StackTrace"
                742, // index: 742, string: "Type"
                5, // array length: 5
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                1, // array length: 1
                352, // index: 352, string: "http://schemas.datacontract.org/2004/07/SunApp.Read"
                1, // array length: 1
                747, // index: 747, string: "Body"
                1, // array length: 1
                352, // index: 352, string: "http://schemas.datacontract.org/2004/07/SunApp.Read"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                1, // array length: 1
                752, // index: 752, string: "ReadEmployeeResult"
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                15, // array length: 15
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                15, // array length: 15
                771, // index: 771, string: "Id"
                774, // index: 774, string: "IdFarm"
                781, // index: 781, string: "Name"
                786, // index: 786, string: "LastName"
                795, // index: 795, string: "NickName"
                804, // index: 804, string: "Email"
                810, // index: 810, string: "Phone"
                816, // index: 816, string: "IdDocument"
                827, // index: 827, string: "Address"
                835, // index: 835, string: "Birthday"
                844, // index: 844, string: "Temp"
                849, // index: 849, string: "DaysAtWork"
                860, // index: 860, string: "FirstHiringDate"
                876, // index: 876, string: "LastHiringDate"
                891, // index: 891, string: "LastResignationDate"
                15, // array length: 15
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                10, // array length: 10
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                10, // array length: 10
                771, // index: 771, string: "Id"
                774, // index: 774, string: "IdFarm"
                781, // index: 781, string: "Name"
                786, // index: 786, string: "LastName"
                795, // index: 795, string: "NickName"
                804, // index: 804, string: "Email"
                810, // index: 810, string: "Phone"
                816, // index: 816, string: "IdDocument"
                827, // index: 827, string: "Address"
                835, // index: 835, string: "Birthday"
                10, // array length: 10
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                1, // array length: 1
                352, // index: 352, string: "http://schemas.datacontract.org/2004/07/SunApp.Read"
                1, // array length: 1
                747, // index: 747, string: "Body"
                1, // array length: 1
                352, // index: 352, string: "http://schemas.datacontract.org/2004/07/SunApp.Read"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                2, // array length: 2
                911, // index: 911, string: "xIdFarm"
                919, // index: 919, string: "xIsTemp"
                2, // array length: 2
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                574, // index: 574, string: "http://schemas.datacontract.org/2004/07/SunApp.AddEmployee"
                1, // array length: 1
                747, // index: 747, string: "Body"
                1, // array length: 1
                574, // index: 574, string: "http://schemas.datacontract.org/2004/07/SunApp.AddEmployee"
                1, // array length: 1
                574, // index: 574, string: "http://schemas.datacontract.org/2004/07/SunApp.AddEmployee"
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                1, // array length: 1
                574, // index: 574, string: "http://schemas.datacontract.org/2004/07/SunApp.AddEmployee"
                1, // array length: 1
                747, // index: 747, string: "Body"
                1, // array length: 1
                574, // index: 574, string: "http://schemas.datacontract.org/2004/07/SunApp.AddEmployee"
                18, // array length: 18
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                18, // array length: 18
                911, // index: 911, string: "xIdFarm"
                927, // index: 927, string: "xName"
                933, // index: 933, string: "xLastName"
                943, // index: 943, string: "xNickName"
                953, // index: 953, string: "xEmail"
                960, // index: 960, string: "xPhone"
                967, // index: 967, string: "xAddress"
                976, // index: 976, string: "xBirthday"
                986, // index: 986, string: "xTemp"
                992, // index: 992, string: "xDaysAtWork"
                1004, // index: 1004, string: "xFistHiringDate"
                1020, // index: 1020, string: "xLastHiringDate"
                1036, // index: 1036, string: "xLastResignationDate"
                1057, // index: 1057, string: "xBrazilCPF"
                1068, // index: 1068, string: "xBrazilRG"
                1078, // index: 1078, string: "xPassport"
                1088, // index: 1088, string: "xBrazilCarteiraDeTrabalho"
                1114, // index: 1114, string: "xBrazilCNPJ"
                18, // array length: 18
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429, // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
                429  // index: 429, string: "http://agroassistant.azurewebsites.net/Services/"
        };
        // Count = 0
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContractMap_Hashtable = new byte[0];
        // Count=49
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                "en=b03f5f7f11d50a3a")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeResponseBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1[[SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=ne" +
                                "utral, PublicKeyToken=null]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                "50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Person, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeRequestBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeResponseBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeRequestBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 161, // 0xa1
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_dataContracts_Hashtable = new byte[0];
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_classDataContracts_Hashtable = new byte[0];
        // Count=11
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ExceptionDetail
                        NamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        StableNameIndex = 255, // ExceptionDetail
                        StableNameNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        TopLevelElementNameIndex = 255, // ExceptionDetail
                        TopLevelElementNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadExceptionDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteExceptionDetailToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 7,
                    MemberNamesListIndex = 9,
                    MemberNamespacesListIndex = 15,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 331, // ReadEmployeeResponse
                        NamespaceIndex = 352, // http://schemas.datacontract.org/2004/07/SunApp.Read
                        StableNameIndex = 331, // ReadEmployeeResponse
                        StableNameNamespaceIndex = 352, // http://schemas.datacontract.org/2004/07/SunApp.Read
                        TopLevelElementNameIndex = 331, // ReadEmployeeResponse
                        TopLevelElementNamespaceIndex = 352, // http://schemas.datacontract.org/2004/07/SunApp.Read
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type2.ReadReadEmployeeResponseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type3.WriteReadEmployeeResponseToXml),
                    ChildElementNamespacesListIndex = 21,
                    ContractNamespacesListIndex = 23,
                    MemberNamesListIndex = 25,
                    MemberNamespacesListIndex = 27,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 404, // ReadEmployeeResponseBody
                        NamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        StableNameIndex = 404, // ReadEmployeeResponseBody
                        StableNameNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        TopLevelElementNameIndex = 404, // ReadEmployeeResponseBody
                        TopLevelElementNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeResponseBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeResponseBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type4.ReadReadEmployeeResponseBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type5.WriteReadEmployeeResponseBodyToXml),
                    ChildElementNamespacesListIndex = 29,
                    ContractNamespacesListIndex = 31,
                    MemberNamesListIndex = 33,
                    MemberNamespacesListIndex = 35,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 494, // Employee
                        NamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        StableNameIndex = 494, // Employee
                        StableNameNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        TopLevelElementNameIndex = 494, // Employee
                        TopLevelElementNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type9.ReadEmployeeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type10.WriteEmployeeToXml),
                    ChildElementNamespacesListIndex = 37,
                    ContractNamespacesListIndex = 53,
                    MemberNamesListIndex = 56,
                    MemberNamespacesListIndex = 72,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 503, // Person
                        NamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        StableNameIndex = 503, // Person
                        StableNameNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        TopLevelElementNameIndex = 503, // Person
                        TopLevelElementNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Person, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Person, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        KnownDataContractsListIndex = 3,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type11.ReadPersonFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type12.WritePersonToXml),
                    ChildElementNamespacesListIndex = 88,
                    ContractNamespacesListIndex = 99,
                    MemberNamesListIndex = 101,
                    MemberNamespacesListIndex = 112,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 510, // ReadEmployeeRequest
                        NamespaceIndex = 352, // http://schemas.datacontract.org/2004/07/SunApp.Read
                        StableNameIndex = 510, // ReadEmployeeRequest
                        StableNameNamespaceIndex = 352, // http://schemas.datacontract.org/2004/07/SunApp.Read
                        TopLevelElementNameIndex = 510, // ReadEmployeeRequest
                        TopLevelElementNamespaceIndex = 352, // http://schemas.datacontract.org/2004/07/SunApp.Read
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type13.ReadReadEmployeeRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type14.WriteReadEmployeeRequestToXml),
                    ChildElementNamespacesListIndex = 123,
                    ContractNamespacesListIndex = 125,
                    MemberNamesListIndex = 127,
                    MemberNamespacesListIndex = 129,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 530, // ReadEmployeeRequestBody
                        NamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        StableNameIndex = 530, // ReadEmployeeRequestBody
                        StableNameNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        TopLevelElementNameIndex = 530, // ReadEmployeeRequestBody
                        TopLevelElementNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeRequestBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.ReadEmployeeRequestBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type15.ReadReadEmployeeRequestBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type16.WriteReadEmployeeRequestBodyToXml),
                    ChildElementNamespacesListIndex = 131,
                    ContractNamespacesListIndex = 134,
                    MemberNamesListIndex = 136,
                    MemberNamespacesListIndex = 139,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 554, // AddEmployeeResponse
                        NamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        StableNameIndex = 554, // AddEmployeeResponse
                        StableNameNamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        TopLevelElementNameIndex = 554, // AddEmployeeResponse
                        TopLevelElementNamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeResponse, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type17.ReadAddEmployeeResponseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type18.WriteAddEmployeeResponseToXml),
                    ChildElementNamespacesListIndex = 142,
                    ContractNamespacesListIndex = 144,
                    MemberNamesListIndex = 146,
                    MemberNamespacesListIndex = 148,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 633, // AddEmployeeResponseBody
                        NamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        StableNameIndex = 633, // AddEmployeeResponseBody
                        StableNameNamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        TopLevelElementNameIndex = 633, // AddEmployeeResponseBody
                        TopLevelElementNamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeResponseBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeResponseBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type19.ReadAddEmployeeResponseBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type20.WriteAddEmployeeResponseBodyToXml),
                    ContractNamespacesListIndex = 150,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 657, // AddEmployeeRequest
                        NamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        StableNameIndex = 657, // AddEmployeeRequest
                        StableNameNamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        TopLevelElementNameIndex = 657, // AddEmployeeRequest
                        TopLevelElementNamespaceIndex = 574, // http://schemas.datacontract.org/2004/07/SunApp.AddEmployee
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeRequest, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type21.ReadAddEmployeeRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type22.WriteAddEmployeeRequestToXml),
                    ChildElementNamespacesListIndex = 152,
                    ContractNamespacesListIndex = 154,
                    MemberNamesListIndex = 156,
                    MemberNamespacesListIndex = 158,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 676, // AddEmployeeRequestBody
                        NamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        StableNameIndex = 676, // AddEmployeeRequestBody
                        StableNameNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        TopLevelElementNameIndex = 676, // AddEmployeeRequestBody
                        TopLevelElementNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeRequestBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.AddEmployee.AddEmployeeRequestBody, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type23.ReadAddEmployeeRequestBodyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type24.WriteAddEmployeeRequestBodyToXml),
                    ChildElementNamespacesListIndex = 160,
                    ContractNamespacesListIndex = 179,
                    MemberNamesListIndex = 181,
                    MemberNamespacesListIndex = 200,
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_collectionDataContracts_Hashtable = new byte[0];
        // Count=1
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 478, // ArrayOfEmployee
                        NamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        StableNameIndex = 478, // ArrayOfEmployee
                        StableNameNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        TopLevelElementNameIndex = 478, // ArrayOfEmployee
                        TopLevelElementNamespaceIndex = 429, // http://agroassistant.azurewebsites.net/Services/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1[[SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=null]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1[[SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=ne" +
                                    "utral, PublicKeyToken=null]], System.ObjectModel, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.0.10.0, Culture=neutral, Pu" +
                                    "blicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type6.ReadArrayOfEmployeeFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type7.WriteArrayOfEmployeeToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type8.ReadArrayOfEmployeeFromXmlIsGetOnly),
                    CollectionItemNameIndex = 494, // Employee
                    KeyNameIndex = -1,
                    ItemNameIndex = 494, // Employee
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("SunApp.Read.Employee, SunApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }
        };
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_enumDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[0];
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly byte[] s_xmlDataContracts_Hashtable = new byte[0];
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','E','x','c','e','p','t','i','o','n','D','e','t','a','i','l',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','S','e','r','v','i','c','e','M','o','d','e','l',
            '\0','R','e','a','d','E','m','p','l','o','y','e','e','R','e','s','p','o','n','s','e','\0','h','t','t','p',':','/','/','s',
            'c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0',
            '7','/','S','u','n','A','p','p','.','R','e','a','d','\0','R','e','a','d','E','m','p','l','o','y','e','e','R','e','s','p',
            'o','n','s','e','B','o','d','y','\0','h','t','t','p',':','/','/','a','g','r','o','a','s','s','i','s','t','a','n','t','.',
            'a','z','u','r','e','w','e','b','s','i','t','e','s','.','n','e','t','/','S','e','r','v','i','c','e','s','/','\0','A','r',
            'r','a','y','O','f','E','m','p','l','o','y','e','e','\0','E','m','p','l','o','y','e','e','\0','P','e','r','s','o','n','\0',
            'R','e','a','d','E','m','p','l','o','y','e','e','R','e','q','u','e','s','t','\0','R','e','a','d','E','m','p','l','o','y',
            'e','e','R','e','q','u','e','s','t','B','o','d','y','\0','A','d','d','E','m','p','l','o','y','e','e','R','e','s','p','o',
            'n','s','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c',
            't','.','o','r','g','/','2','0','0','4','/','0','7','/','S','u','n','A','p','p','.','A','d','d','E','m','p','l','o','y',
            'e','e','\0','A','d','d','E','m','p','l','o','y','e','e','R','e','s','p','o','n','s','e','B','o','d','y','\0','A','d','d',
            'E','m','p','l','o','y','e','e','R','e','q','u','e','s','t','\0','A','d','d','E','m','p','l','o','y','e','e','R','e','q',
            'u','e','s','t','B','o','d','y','\0','H','e','l','p','L','i','n','k','\0','I','n','n','e','r','E','x','c','e','p','t','i',
            'o','n','\0','M','e','s','s','a','g','e','\0','S','t','a','c','k','T','r','a','c','e','\0','T','y','p','e','\0','B','o','d',
            'y','\0','R','e','a','d','E','m','p','l','o','y','e','e','R','e','s','u','l','t','\0','I','d','\0','I','d','F','a','r','m',
            '\0','N','a','m','e','\0','L','a','s','t','N','a','m','e','\0','N','i','c','k','N','a','m','e','\0','E','m','a','i','l','\0',
            'P','h','o','n','e','\0','I','d','D','o','c','u','m','e','n','t','\0','A','d','d','r','e','s','s','\0','B','i','r','t','h',
            'd','a','y','\0','T','e','m','p','\0','D','a','y','s','A','t','W','o','r','k','\0','F','i','r','s','t','H','i','r','i','n',
            'g','D','a','t','e','\0','L','a','s','t','H','i','r','i','n','g','D','a','t','e','\0','L','a','s','t','R','e','s','i','g',
            'n','a','t','i','o','n','D','a','t','e','\0','x','I','d','F','a','r','m','\0','x','I','s','T','e','m','p','\0','x','N','a',
            'm','e','\0','x','L','a','s','t','N','a','m','e','\0','x','N','i','c','k','N','a','m','e','\0','x','E','m','a','i','l','\0',
            'x','P','h','o','n','e','\0','x','A','d','d','r','e','s','s','\0','x','B','i','r','t','h','d','a','y','\0','x','T','e','m',
            'p','\0','x','D','a','y','s','A','t','W','o','r','k','\0','x','F','i','s','t','H','i','r','i','n','g','D','a','t','e','\0',
            'x','L','a','s','t','H','i','r','i','n','g','D','a','t','e','\0','x','L','a','s','t','R','e','s','i','g','n','a','t','i',
            'o','n','D','a','t','e','\0','x','B','r','a','z','i','l','C','P','F','\0','x','B','r','a','z','i','l','R','G','\0','x','P',
            'a','s','s','p','o','r','t','\0','x','B','r','a','z','i','l','C','a','r','t','e','i','r','a','D','e','T','r','a','b','a',
            'l','h','o','\0','x','B','r','a','z','i','l','C','N','P','J','\0'};
    }
}
