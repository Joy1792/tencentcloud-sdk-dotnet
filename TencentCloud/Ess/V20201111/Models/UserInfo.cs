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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户在平台的编号
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户的来源渠道，一般不用传，特定场景根据接口说明传值
        /// </summary>
        [JsonProperty("Channel")]
        [System.Obsolete]
        public string Channel{ get; set; }

        /// <summary>
        /// 用户在渠道的编号，一般不用传，特定场景根据接口说明传值
        /// </summary>
        [JsonProperty("OpenId")]
        [System.Obsolete]
        public string OpenId{ get; set; }

        /// <summary>
        /// 用户真实IP，内部字段，暂未开放
        /// </summary>
        [JsonProperty("ClientIp")]
        [System.Obsolete]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 用户代理IP，内部字段，暂未开放
        /// </summary>
        [JsonProperty("ProxyIp")]
        [System.Obsolete]
        public string ProxyIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ProxyIp", this.ProxyIp);
        }
    }
}

