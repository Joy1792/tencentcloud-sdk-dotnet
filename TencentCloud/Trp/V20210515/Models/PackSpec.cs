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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PackSpec : AbstractModel
    {
        
        /// <summary>
        /// 层级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 比例
        /// </summary>
        [JsonProperty("Rate")]
        public ulong? Rate{ get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("Amount")]
        public ulong? Amount{ get; set; }

        /// <summary>
        /// 码规则ID
        /// </summary>
        [JsonProperty("CustomId")]
        public string CustomId{ get; set; }

        /// <summary>
        /// 码段配置
        /// </summary>
        [JsonProperty("CodeParts")]
        public CodePart[] CodeParts{ get; set; }

        /// <summary>
        /// 包装单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 场景值
        /// </summary>
        [JsonProperty("SceneCode")]
        public long? SceneCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "Amount", this.Amount);
            this.SetParamSimple(map, prefix + "CustomId", this.CustomId);
            this.SetParamArrayObj(map, prefix + "CodeParts.", this.CodeParts);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
        }
    }
}

