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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndicatorItem : AbstractModel
    {
        
        /// <summary>
        /// 英文缩写
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 标准缩写
        /// </summary>
        [JsonProperty("Scode")]
        public string Scode{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 标准名
        /// </summary>
        [JsonProperty("Sname")]
        public string Sname{ get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 参考范围
        /// </summary>
        [JsonProperty("Range")]
        public string Range{ get; set; }

        /// <summary>
        /// 上下箭头
        /// </summary>
        [JsonProperty("Arrow")]
        public string Arrow{ get; set; }

        /// <summary>
        /// 是否正常
        /// </summary>
        [JsonProperty("Normal")]
        public bool? Normal{ get; set; }

        /// <summary>
        /// 项目原文
        /// </summary>
        [JsonProperty("ItemString")]
        public string ItemString{ get; set; }

        /// <summary>
        /// 指标项ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 指标项坐标位置
        /// </summary>
        [JsonProperty("Coords")]
        public Coordinate Coords{ get; set; }

        /// <summary>
        /// 推测结果是否异常
        /// </summary>
        [JsonProperty("InferNormal")]
        public string InferNormal{ get; set; }

        /// <summary>
        /// 标本
        /// </summary>
        [JsonProperty("Sample")]
        public string Sample{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Scode", this.Scode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sname", this.Sname);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Range", this.Range);
            this.SetParamSimple(map, prefix + "Arrow", this.Arrow);
            this.SetParamSimple(map, prefix + "Normal", this.Normal);
            this.SetParamSimple(map, prefix + "ItemString", this.ItemString);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Coords.", this.Coords);
            this.SetParamSimple(map, prefix + "InferNormal", this.InferNormal);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
        }
    }
}

