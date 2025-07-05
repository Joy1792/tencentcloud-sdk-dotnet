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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteInternalEndpointDnsRequest : AbstractModel
    {
        
        /// <summary>
        /// tcr实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 私有网络id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// tcr内网访问链路ip
        /// </summary>
        [JsonProperty("EniLBIp")]
        public string EniLBIp{ get; set; }

        /// <summary>
        /// true：使用默认域名
        /// false:  使用带有vpc的域名
        /// </summary>
        [JsonProperty("UsePublicDomain")]
        public bool? UsePublicDomain{ get; set; }

        /// <summary>
        /// 解析地域，需要保证和vpc处于同一地域，如果不填则默认为主实例地域
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "EniLBIp", this.EniLBIp);
            this.SetParamSimple(map, prefix + "UsePublicDomain", this.UsePublicDomain);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
        }
    }
}

