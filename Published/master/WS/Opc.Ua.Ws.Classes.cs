/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Ws
{
    #region WeightScaleState Class
    #if (!OPCUA_EXCLUDE_WeightScaleState)
    /// <summary>
    /// Stores an instance of the WeightScaleType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class WeightScaleState : DeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public WeightScaleState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Ws.ObjectTypes.WeightScaleType, Opc.Ua.Ws.Namespaces.OpcUaWs, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB4AAABodHRwOi8vcGhpLXdhcmUuY29tL0ZFSVNUVS9XUy8fAAAAaHR0cDovL29wY2ZvdW5kYXRp" +
           "b24ub3JnL1VBL0RJL/////+EYIACAQAAAAEAFwAAAFdlaWdodFNjYWxlVHlwZUluc3RhbmNlAQGlOwEB" +
           "pTulOwAAAf////8KAAAAJGCACgEAAAABAAwAAABQYXJhbWV0ZXJTZXQBAaY7AwAAAAAXAAAARmxhdCBs" +
           "aXN0IG9mIFBhcmFtZXRlcnMALwA6pjsAAP////8BAAAANWCJCgIAAAABAAsAAAB3ZWlnaHRTY2FsZQEB" +
           "6zsDAAAAAA4AAABBY3R1YWwgd2VpZ2h0LgAvAQBACes7AAAAC/////8DA/////8DAAAAFWCJCgIAAAAB" +
           "AA8AAABJbnN0cnVtZW50UmFuZ2UBAe47AC4ARO47AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "BwAAAEVVUmFuZ2UBAe87AC4ARO87AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEAEAAAAEVuZ2lu" +
           "ZWVyaW5nVW5pdHMBAfA7AC4ARPA7AAABAHcD/////wEB/////wAAAAAkYIAKAQAAAAEACQAAAE1ldGhv" +
           "ZFNldAEBqDsDAAAAABQAAABGbGF0IGxpc3Qgb2YgTWV0aG9kcwAvADqoOwAA/////wIAAAAkYYIKBAAA" +
           "AAEABAAAAFRhcmUBAfE7AwAAAAANAAAAVGFyZSBiYWxuYWNlLgAvAQHxO/E7AAABAf////8AAAAAJGGC" +
           "CgQAAAABAAQAAABaZXJvAQHyOwMAAAAADQAAAFplcm8gYmFsbmFjZS4ALwEB8jvyOwAAAQH/////AAAA" +
           "ADVgiQoCAAAAAgAMAAAATWFudWZhY3R1cmVyAQG8OwMAAAAAMAAAAE5hbWUgb2YgdGhlIGNvbXBhbnkg" +
           "dGhhdCBtYW51ZmFjdHVyZWQgdGhlIGRldmljZQAuAES8OwAAABX/////AQH/////AAAAADVgiQoCAAAA" +
           "AgAFAAAATW9kZWwBAb47AwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUgZGV2aWNlAC4ARL47AAAAFf//" +
           "//8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJkd2FyZVJldmlzaW9uAQG/OwMAAAAALAAAAFJldmlz" +
           "aW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0aGUgZGV2aWNlAC4ARL87AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlzaW9uAQHAOwMAAAAANQAAAFJldmlzaW9uIGxldmVs" +
           "IG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0aGUgZGV2aWNlAC4ARMA7AAAADP////8BAf////8A" +
           "AAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lvbgEBwTsDAAAAACQAAABPdmVyYWxsIHJldmlzaW9u" +
           "IGxldmVsIG9mIHRoZSBkZXZpY2UALgBEwTsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERl" +
           "dmljZU1hbnVhbAEBwzsDAAAAAFoAAABBZGRyZXNzIChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0g" +
           "b3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNlciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEwzsA" +
           "AAAM/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAFNlcmlhbE51bWJlcgEBxTsDAAAAAE0AAABJZGVu" +
           "dGlmaWVyIHRoYXQgdW5pcXVlbHkgaWRlbnRpZmllcywgd2l0aGluIGEgbWFudWZhY3R1cmVyLCBhIGRl" +
           "dmljZSBpbnN0YW5jZQAuAETFOwAAAAz/////AQH/////AAAAADVgiQoCAAAAAgAPAAAAUmV2aXNpb25D" +
           "b3VudGVyAQHHOwMAAAAAaQAAAEFuIGluY3JlbWVudGFsIGNvdW50ZXIgaW5kaWNhdGluZyB0aGUgbnVt" +
           "YmVyIG9mIHRpbWVzIHRoZSBzdGF0aWMgZGF0YSB3aXRoaW4gdGhlIERldmljZSBoYXMgYmVlbiBtb2Rp" +
           "ZmllZAAuAETHOwAAAAb/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MettlerToledoPR802State Class
    #if (!OPCUA_EXCLUDE_MettlerToledoPR802State)
    /// <summary>
    /// Stores an instance of the MettlerToledoPR802 ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MettlerToledoPR802State : WeightScaleState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MettlerToledoPR802State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Ws.ObjectTypes.MettlerToledoPR802, Opc.Ua.Ws.Namespaces.OpcUaWs, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAAB4AAABodHRwOi8vcGhpLXdhcmUuY29tL0ZFSVNUVS9XUy8fAAAAaHR0cDovL29wY2ZvdW5kYXRp" +
           "b24ub3JnL1VBL0RJL/////+EYIACAQAAAAEAGgAAAE1ldHRsZXJUb2xlZG9QUjgwMkluc3RhbmNlAQFF" +
           "OwEBRTtFOwAAAf////8LAAAAJGCACgEAAAABAAwAAABQYXJhbWV0ZXJTZXQBAUY7AwAAAAAXAAAARmxh" +
           "dCBsaXN0IG9mIFBhcmFtZXRlcnMALwA6RjsAAP////8NAAAANWDJCgIAAAAVAAAAQ09NX1NlcmlhbFBv" +
           "cnRfU3RhdHVzAQAOAAAAQ09NQ29ubl9TdGF0dXMBAZo7AwAAAAAcAAAAU2VyaWFsIHBvcnQgdG8gc2Nh" +
           "bGUgc3RhdHVzLgAvAESaOwAAABv/////AwP/////AAAAADVgiQoCAAAAAQAfAAAAU3RhdGljU2NhbGVf" +
           "RmlsbGVyXzAxLldWX1NUQUJMRQEBmzsDAAAAAB8AAABTdGF0aWNTY2FsZSBGaWxsZXIgMDEgV1ZfU1RB" +
           "QkxFAC8ARJs7AAAADP////8DA/////8AAAAANWCJCgIAAAABABgAAABTdGF0aWNTY2FsZV9GaWxsZXJf" +
           "MDEuV1YBAZw7AwAAAAAYAAAAU3RhdGljU2NhbGUgRmlsbGVyIDAxIFdWAC8ARJw7AAAADP////8DA///" +
           "//8AAAAANWCJCgIAAAABACAAAABTdGF0aWNTY2FsZV9GaWxsZXJfMDEuQ09NTUFORF9TSQEBnTsDAAAA" +
           "ACAAAABTdGF0aWNTY2FsZSBGaWxsZXIgMDEgQ09NTUFORF9TSQAvAESdOwAAAAz/////AwP/////AAAA" +
           "ADVgiQoCAAAAAQAfAAAAU3RhdGljU2NhbGVfRmlsbGVyXzAyLldWX1NUQUJMRQEBnjsDAAAAAB8AAABT" +
           "dGF0aWNTY2FsZSBGaWxsZXIgMDIgV1ZfU1RBQkxFAC8ARJ47AAAADP////8DA/////8AAAAANWCJCgIA" +
           "AAABABgAAABTdGF0aWNTY2FsZV9GaWxsZXJfMDIuV1YBAZ87AwAAAAAYAAAAU3RhdGljU2NhbGUgRmls" +
           "bGVyIDAyIFdWAC8ARJ87AAAADP////8DA/////8AAAAANWCJCgIAAAABACAAAABTdGF0aWNTY2FsZV9G" +
           "aWxsZXJfMDIuQ09NTUFORF9TSQEBoDsDAAAAACAAAABTdGF0aWNTY2FsZSBGaWxsZXIgMDIgQ09NTUFO" +
           "RF9TSQAvAESgOwAAAAz/////AwP/////AAAAADVgiQoCAAAAAQAfAAAAU3RhdGljU2NhbGVfRmlsbGVy" +
           "XzAzLldWX1NUQUJMRQEBoTsDAAAAAB8AAABTdGF0aWNTY2FsZSBGaWxsZXIgMDMgV1ZfU1RBQkxFAC8A" +
           "RKE7AAAADP////8DA/////8AAAAANWCJCgIAAAABABgAAABTdGF0aWNTY2FsZV9GaWxsZXJfMDMuV1YB" +
           "AaI7AwAAAAAYAAAAU3RhdGljU2NhbGUgRmlsbGVyIDAzIFdWAC8ARKI7AAAADP////8DA/////8AAAAA" +
           "NWCJCgIAAAABACAAAABTdGF0aWNTY2FsZV9GaWxsZXJfMDMuQ09NTUFORF9TSQEBozsDAAAAACAAAABT" +
           "dGF0aWNTY2FsZSBGaWxsZXIgMDMgQ09NTUFORF9TSQAvAESjOwAAAAz/////AwP/////AAAAADVgiQoC" +
           "AAAAAQAMAAAAU0NfTmV0V2VpZ2h0AQGkOwMAAAAAHAAAAFN0YXRpYyBTY2FsZSB2YWx1ZSBmcm9tIFBM" +
           "Qy4ALwBEpDsAAAAK/////wMD/////wAAAAA1YIkKAgAAAAEACQAAAFNDX1N0YXR1cwEB8zsDAAAAACcA" +
           "AABTdGF0aWMgc2NhbGUgSGFuZHNoYWtpbmcgc2lnbmFsIHN0YXR1cy4ALwBE8zsAAAAb/////wMD////" +
           "/wAAAAA1YIkKAgAAAAEAFQAAAFNDX1N0YWJpbGl0eUluZGljYXRvcgEB9DsDAAAAAC4AAABTdGF0aWMg" +
           "c2NhbGXigJlzIHN0YWJpbGl0eSBpbmRpY2F0b3IgZnJvbSBQTEMuAC8ARPQ7AAAAAf////8DA/////8A" +
           "AAAAJGCACgEAAAABAAkAAABNZXRob2RTZXQBAU87AwAAAAAUAAAARmxhdCBsaXN0IG9mIE1ldGhvZHMA" +
           "LwA6TzsAAP////8GAAAAJGGCCgQAAAABAAQAAABUYXJlAQGYOwMAAAAADQAAAFRhcmUgYmFsbmFjZS4A" +
           "LwEB8TuYOwAAAQH/////AAAAACRhggoEAAAAAQAEAAAAWmVybwEBmTsDAAAAAA0AAABaZXJvIGJhbG5h" +
           "Y2UuAC8BAfI7mTsAAAEB/////wAAAAAkYYIKBAAAAAEACwAAAENPTV9Db25uZWN0AQH1OwMAAAAAEQAA" +
           "AENvbm5lY3QgdG8gc2NhbGUuAC8BAfU79TsAAAEB/////wAAAAAkYYIKBAAAAAEADwAAAENPTV9Jc0Nv" +
           "bm5lY3RlZAEB+DsDAAAAABwAAABDaGVjayBpZiBzY2FsZSBpcyBjb25uZWN0ZWQuAC8BAfg7+DsAAAEB" +
           "/////wAAAAAkYYIKBAAAAAEAFQAAAENPTV9TZW5kTVRTSUNTQ29tbWFuZAEB+jsDAAAAABUAAABTZW5k" +
           "IE1UIFNJQ1MgQ29tbWFuZC4ALwEB+jv6OwAAAQH/////AAAAACRhggoEAAAAAQANAAAAQ09NX0Rpc2Nv" +
           "bmVjdAEB/TsDAAAAABYAAABEaXNjb25uZWN0IGZyb20gc2NhbGUuAC8BAf07/TsAAAEB/////wAAAAA1" +
           "YKkKAgAAAAIADAAAAE1hbnVmYWN0dXJlcgEBYzsDAAAAADAAAABOYW1lIG9mIHRoZSBjb21wYW55IHRo" +
           "YXQgbWFudWZhY3R1cmVkIHRoZSBkZXZpY2UALgBEYzsAABUCDgAAAE1ldHRsZXIgVG9sZWRvABX/////" +
           "AQH/////AAAAADVgqQoCAAAAAgAFAAAATW9kZWwBAWU7AwAAAAAYAAAATW9kZWwgbmFtZSBvZiB0aGUg" +
           "ZGV2aWNlAC4ARGU7AAAVAgYAAABQUiA4MDIAFf////8BAf////8AAAAANWCJCgIAAAACABAAAABIYXJk" +
           "d2FyZVJldmlzaW9uAQFmOwMAAAAALAAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBoYXJkd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARGY7AAAADP////8BAf////8AAAAANWCJCgIAAAACABAAAABTb2Z0d2FyZVJldmlz" +
           "aW9uAQFnOwMAAAAANQAAAFJldmlzaW9uIGxldmVsIG9mIHRoZSBzb2Z0d2FyZS9maXJtd2FyZSBvZiB0" +
           "aGUgZGV2aWNlAC4ARGc7AAAADP////8BAf////8AAAAANWCJCgIAAAACAA4AAABEZXZpY2VSZXZpc2lv" +
           "bgEBaDsDAAAAACQAAABPdmVyYWxsIHJldmlzaW9uIGxldmVsIG9mIHRoZSBkZXZpY2UALgBEaDsAAAAM" +
           "/////wEB/////wAAAAA1YIkKAgAAAAIADAAAAERldmljZU1hbnVhbAEBajsDAAAAAFoAAABBZGRyZXNz" +
           "IChwYXRobmFtZSBpbiB0aGUgZmlsZSBzeXN0ZW0gb3IgYSBVUkwgfCBXZWIgYWRkcmVzcykgb2YgdXNl" +
           "ciBtYW51YWwgZm9yIHRoZSBkZXZpY2UALgBEajsAAAAM/////wEB/////wAAAAA1YKkKAgAAAAIACwAA" +
           "AERldmljZUNsYXNzAQFrOwMAAAAAPwAAAEluZGljYXRlcyBpbiB3aGljaCBkb21haW4gb3IgZm9yIHdo" +
           "YXQgcHVycG9zZSBhIGRldmljZSBpcyB1c2VkLgAuAERrOwAADAwAAABTdGF0aWMgU2NhbGUADP////8B" +
           "Af////8AAAAANWCJCgIAAAACAAwAAABTZXJpYWxOdW1iZXIBAWw7AwAAAABNAAAASWRlbnRpZmllciB0" +
           "aGF0IHVuaXF1ZWx5IGlkZW50aWZpZXMsIHdpdGhpbiBhIG1hbnVmYWN0dXJlciwgYSBkZXZpY2UgaW5z" +
           "dGFuY2UALgBEbDsAAAAM/////wEB/////wAAAAA1YIkKAgAAAAIADwAAAFJldmlzaW9uQ291bnRlcgEB" +
           "bjsDAAAAAGkAAABBbiBpbmNyZW1lbnRhbCBjb3VudGVyIGluZGljYXRpbmcgdGhlIG51bWJlciBvZiB0" +
           "aW1lcyB0aGUgc3RhdGljIGRhdGEgd2l0aGluIHRoZSBEZXZpY2UgaGFzIGJlZW4gbW9kaWZpZWQALgBE" +
           "bjsAAAAG/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}