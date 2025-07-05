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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceServer : AbstractModel
    {
        
        /// <summary>
        /// 源站的地址（IP或者域名）
        /// </summary>
        [JsonProperty("RealServer")]
        public string RealServer{ get; set; }

        /// <summary>
        /// 源站的地址类型，取值[
        /// 1(域名地址)
        /// 2(IP地址)
        /// ]
        /// </summary>
        [JsonProperty("RsType")]
        public long? RsType{ get; set; }

        /// <summary>
        /// 源站的回源权重，取值1~100
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 端口号：0~65535
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RealServer", this.RealServer);
            this.SetParamSimple(map, prefix + "RsType", this.RsType);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Port", this.Port);
        }
    }
}

