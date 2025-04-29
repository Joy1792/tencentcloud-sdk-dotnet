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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BgpPeer : AbstractModel
    {
        
        /// <summary>
        /// 腾讯侧BGP ASN
        /// </summary>
        [JsonProperty("CloudAsn")]
        public long? CloudAsn{ get; set; }

        /// <summary>
        /// 用户侧BGP ASN
        /// </summary>
        [JsonProperty("Asn")]
        public long? Asn{ get; set; }

        /// <summary>
        /// 用户侧BGP密钥
        /// </summary>
        [JsonProperty("AuthKey")]
        public string AuthKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloudAsn", this.CloudAsn);
            this.SetParamSimple(map, prefix + "Asn", this.Asn);
            this.SetParamSimple(map, prefix + "AuthKey", this.AuthKey);
        }
    }
}

