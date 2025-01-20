/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetworkAclEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络ACL实例ID。例如：acl-12345678。
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// 网络ACL规则集。NetworkAclEntrySet和NetworkAclQuintupleSet只能输入一个。
        /// </summary>
        [JsonProperty("NetworkAclEntrySet")]
        public NetworkAclEntrySet NetworkAclEntrySet{ get; set; }

        /// <summary>
        /// 网络ACL五元组规则集。NetworkAclEntrySet和NetworkAclQuintupleSet只能输入一个。
        /// </summary>
        [JsonProperty("NetworkAclQuintupleSet")]
        public NetworkAclQuintupleEntries NetworkAclQuintupleSet{ get; set; }

        /// <summary>
        /// 三元组的增量更新。该接口的默认语义为全量覆盖。当需要实现增量更新语义时，设置该参数为True。
        /// </summary>
        [JsonProperty("EnableUpdateAclEntries")]
        public bool? EnableUpdateAclEntries{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamObj(map, prefix + "NetworkAclEntrySet.", this.NetworkAclEntrySet);
            this.SetParamObj(map, prefix + "NetworkAclQuintupleSet.", this.NetworkAclQuintupleSet);
            this.SetParamSimple(map, prefix + "EnableUpdateAclEntries", this.EnableUpdateAclEntries);
        }
    }
}

