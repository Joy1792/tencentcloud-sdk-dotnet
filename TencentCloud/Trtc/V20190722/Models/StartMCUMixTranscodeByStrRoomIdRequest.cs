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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartMCUMixTranscodeByStrRoomIdRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的SDKAppId。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 字符串房间号。
        /// </summary>
        [JsonProperty("StrRoomId")]
        public string StrRoomId{ get; set; }

        /// <summary>
        /// 混流输出控制参数。
        /// </summary>
        [JsonProperty("OutputParams")]
        public OutputParams OutputParams{ get; set; }

        /// <summary>
        /// 混流输出编码参数。
        /// </summary>
        [JsonProperty("EncodeParams")]
        public EncodeParams EncodeParams{ get; set; }

        /// <summary>
        /// 混流输出布局参数。
        /// </summary>
        [JsonProperty("LayoutParams")]
        public LayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// 第三方CDN转推参数。如需转推至腾讯云云直播，此参数无需填写，会默认转推
        /// </summary>
        [JsonProperty("PublishCdnParams")]
        public PublishCdnParams PublishCdnParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StrRoomId", this.StrRoomId);
            this.SetParamObj(map, prefix + "OutputParams.", this.OutputParams);
            this.SetParamObj(map, prefix + "EncodeParams.", this.EncodeParams);
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamObj(map, prefix + "PublishCdnParams.", this.PublishCdnParams);
        }
    }
}

