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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateFleetPortSettingsRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务器舰队 Id
        /// </summary>
        [JsonProperty("FleetId")]
        public string FleetId{ get; set; }

        /// <summary>
        /// 新增安全组
        /// </summary>
        [JsonProperty("InboundPermissionAuthorizations")]
        public InboundPermissionAuthorization[] InboundPermissionAuthorizations{ get; set; }

        /// <summary>
        /// 移除安全组
        /// </summary>
        [JsonProperty("InboundPermissionRevocations")]
        public InboundPermissionRevocations[] InboundPermissionRevocations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FleetId", this.FleetId);
            this.SetParamArrayObj(map, prefix + "InboundPermissionAuthorizations.", this.InboundPermissionAuthorizations);
            this.SetParamArrayObj(map, prefix + "InboundPermissionRevocations.", this.InboundPermissionRevocations);
        }
    }
}

