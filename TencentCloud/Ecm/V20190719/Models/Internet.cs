/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Internet : AbstractModel
    {
        
        /// <summary>
        /// 实例的内网相关信息列表。顺序为主网卡在前，辅助网卡按绑定先后顺序排列。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateIPAddressSet")]
        public PrivateIPAddressInfo[] PrivateIPAddressSet{ get; set; }

        /// <summary>
        /// 实例的公网相关信息列表。顺序为主网卡在前，辅助网卡按绑定先后顺序排列。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicIPAddressSet")]
        public PublicIPAddressInfo[] PublicIPAddressSet{ get; set; }

        /// <summary>
        /// 实例网络相关信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceNetworkInfoSet")]
        public InstanceNetworkInfo[] InstanceNetworkInfoSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "PrivateIPAddressSet.", this.PrivateIPAddressSet);
            this.SetParamArrayObj(map, prefix + "PublicIPAddressSet.", this.PublicIPAddressSet);
            this.SetParamArrayObj(map, prefix + "InstanceNetworkInfoSet.", this.InstanceNetworkInfoSet);
        }
    }
}

