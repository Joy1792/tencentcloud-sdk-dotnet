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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTDidByPubKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// DID应用id
        /// </summary>
        [JsonProperty("DAPId")]
        public ulong? DAPId{ get; set; }

        /// <summary>
        /// pem格式的认证公钥
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// 自定义DID初始化属性json字符串
        /// </summary>
        [JsonProperty("CustomAttribute")]
        public string CustomAttribute{ get; set; }

        /// <summary>
        /// 0:did存在返回错误，1:did存在返回该did，默认:0
        /// </summary>
        [JsonProperty("IgnoreExisted")]
        public ulong? IgnoreExisted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DAPId", this.DAPId);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamSimple(map, prefix + "CustomAttribute", this.CustomAttribute);
            this.SetParamSimple(map, prefix + "IgnoreExisted", this.IgnoreExisted);
        }
    }
}

