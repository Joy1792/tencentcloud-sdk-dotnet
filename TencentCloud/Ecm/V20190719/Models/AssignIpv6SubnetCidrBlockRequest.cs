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

    public class AssignIpv6SubnetCidrBlockRequest : AbstractModel
    {
        
        /// <summary>
        /// 子网所在私有网络`ID`。形如：`vpc-f49l6u0z`。	
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 分配 `IPv6` 子网段列表。
        /// </summary>
        [JsonProperty("Ipv6SubnetCidrBlocks")]
        public Ipv6SubnetCidrBlock[] Ipv6SubnetCidrBlocks{ get; set; }

        /// <summary>
        /// ECM地域。
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArrayObj(map, prefix + "Ipv6SubnetCidrBlocks.", this.Ipv6SubnetCidrBlocks);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
        }
    }
}

