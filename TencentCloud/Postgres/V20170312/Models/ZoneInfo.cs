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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// 该可用区的英文名称
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 该可用区的中文名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 该可用区对应的数字编号
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 可用状态包含，
        /// UNAVAILABLE：不可用。
        /// AVAILABLE：可用。
        /// SELLOUT：售罄。
        /// SUPPORTMODIFYONLY：支持变配。
        /// </summary>
        [JsonProperty("ZoneState")]
        public string ZoneState{ get; set; }

        /// <summary>
        /// 该可用区是否支持Ipv6
        /// </summary>
        [JsonProperty("ZoneSupportIpv6")]
        public ulong? ZoneSupportIpv6{ get; set; }

        /// <summary>
        /// 该可用区对应的备可用区集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandbyZoneSet")]
        public string[] StandbyZoneSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneState", this.ZoneState);
            this.SetParamSimple(map, prefix + "ZoneSupportIpv6", this.ZoneSupportIpv6);
            this.SetParamArraySimple(map, prefix + "StandbyZoneSet.", this.StandbyZoneSet);
        }
    }
}

