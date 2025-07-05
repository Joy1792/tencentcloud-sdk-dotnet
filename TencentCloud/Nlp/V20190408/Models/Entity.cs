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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Entity : AbstractModel
    {
        
        /// <summary>
        /// 基础词。
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }

        /// <summary>
        /// 基础词在NormalText中的起始位置。
        /// </summary>
        [JsonProperty("BeginOffset")]
        public long? BeginOffset{ get; set; }

        /// <summary>
        /// 基础词的长度。
        /// </summary>
        [JsonProperty("Length")]
        public long? Length{ get; set; }

        /// <summary>
        /// 实体类型的标准名字。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 类型名字的自然语言表达。（中文或英文）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Word", this.Word);
            this.SetParamSimple(map, prefix + "BeginOffset", this.BeginOffset);
            this.SetParamSimple(map, prefix + "Length", this.Length);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

