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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TColumn : AbstractModel
    {
        
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 字段描述
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 字段默认值
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 字段是否是非空
        /// </summary>
        [JsonProperty("NotNull")]
        public bool? NotNull{ get; set; }

        /// <summary>
        /// 表示整个 numeric 的长度,取值1-38
        /// </summary>
        [JsonProperty("Precision")]
        public long? Precision{ get; set; }

        /// <summary>
        /// 表示小数部分的长度
        /// Scale小于Precision
        /// </summary>
        [JsonProperty("Scale")]
        public long? Scale{ get; set; }

        /// <summary>
        /// 字段位置，小的在前
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }

        /// <summary>
        /// 是否为分区字段
        /// </summary>
        [JsonProperty("IsPartition")]
        public bool? IsPartition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamSimple(map, prefix + "NotNull", this.NotNull);
            this.SetParamSimple(map, prefix + "Precision", this.Precision);
            this.SetParamSimple(map, prefix + "Scale", this.Scale);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "IsPartition", this.IsPartition);
        }
    }
}

