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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetTlsVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// TLS版本,可选TLSv1、TLSv1.1、TLSv1.2、TLSv1.3
        /// </summary>
        [JsonProperty("TLSSupportVersion")]
        public string[] TLSSupportVersion{ get; set; }

        /// <summary>
        /// 密码套件包,可选 GAAP_TLS_CIPHERS_STRICT，GAAP_TLS_CIPHERS_GENERAL，GAAP_TLS_CIPHERS_WIDE(默认)
        /// </summary>
        [JsonProperty("TLSCiphers")]
        public string TLSCiphers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamArraySimple(map, prefix + "TLSSupportVersion.", this.TLSSupportVersion);
            this.SetParamSimple(map, prefix + "TLSCiphers", this.TLSCiphers);
        }
    }
}

