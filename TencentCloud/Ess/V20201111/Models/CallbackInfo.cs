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

    public class CallbackInfo : AbstractModel
    {
        
        /// <summary>
        /// 回调url,。请确保回调地址能够接收并处理 HTTP POST 请求，并返回状态码 200 以表示处理正常。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 回调加密key，已废弃
        /// </summary>
        [JsonProperty("Token")]
        [System.Obsolete]
        public string Token{ get; set; }

        /// <summary>
        /// 回调加密key，用于回调消息加解密。
        /// </summary>
        [JsonProperty("CallbackKey")]
        public string CallbackKey{ get; set; }

        /// <summary>
        /// 回调验签token，用于回调通知校验。
        /// </summary>
        [JsonProperty("CallbackToken")]
        public string CallbackToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "CallbackKey", this.CallbackKey);
            this.SetParamSimple(map, prefix + "CallbackToken", this.CallbackToken);
        }
    }
}

