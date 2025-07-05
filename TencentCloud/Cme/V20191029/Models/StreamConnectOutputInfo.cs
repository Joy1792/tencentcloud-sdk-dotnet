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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamConnectOutputInfo : AbstractModel
    {
        
        /// <summary>
        /// 输出源。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamConnectOutput")]
        public StreamConnectOutput StreamConnectOutput{ get; set; }

        /// <summary>
        /// 输出流状态：
        /// <li>On ：开；</li>
        /// <li>Off ：关 。</li>
        /// </summary>
        [JsonProperty("PushSwitch")]
        public string PushSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "StreamConnectOutput.", this.StreamConnectOutput);
            this.SetParamSimple(map, prefix + "PushSwitch", this.PushSwitch);
        }
    }
}

