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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KeyRule : AbstractModel
    {
        
        /// <summary>
        /// CacheType 对应类型下的匹配内容：
        /// file 时填充后缀名，如 jpg、txt
        /// directory 时填充路径，如 /xxx/test
        /// path 时填充绝对路径，如 /xxx/test.html
        /// index 时填充 /
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// 规则类型：
        /// file：指定文件后缀生效
        /// directory：指定路径生效
        /// path：指定绝对路径生效
        /// index：首页
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 是否开启全路径缓存
        /// on：开启全路径缓存（即关闭参数忽略）
        /// off：关闭全路径缓存（即开启参数忽略）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullUrlCache")]
        public string FullUrlCache{ get; set; }

        /// <summary>
        /// 是否忽略大小写缓存
        /// on：开启
        /// off：关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public string IgnoreCase{ get; set; }

        /// <summary>
        /// CacheKey中包含请求参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueryString")]
        public RuleQueryString QueryString{ get; set; }

        /// <summary>
        /// 路径缓存键标签，传 user
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleTag")]
        public string RuleTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "FullUrlCache", this.FullUrlCache);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamObj(map, prefix + "QueryString.", this.QueryString);
            this.SetParamSimple(map, prefix + "RuleTag", this.RuleTag);
        }
    }
}

