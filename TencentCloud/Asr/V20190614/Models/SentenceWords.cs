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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentenceWords : AbstractModel
    {
        
        /// <summary>
        /// 词文本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }

        /// <summary>
        /// 在句子中的开始时间偏移量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OffsetStartMs")]
        public long? OffsetStartMs{ get; set; }

        /// <summary>
        /// 在句子中的结束时间偏移量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OffsetEndMs")]
        public long? OffsetEndMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Word", this.Word);
            this.SetParamSimple(map, prefix + "OffsetStartMs", this.OffsetStartMs);
            this.SetParamSimple(map, prefix + "OffsetEndMs", this.OffsetEndMs);
        }
    }
}

