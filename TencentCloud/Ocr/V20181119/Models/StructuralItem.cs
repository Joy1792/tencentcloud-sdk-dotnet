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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StructuralItem : AbstractModel
    {
        
        /// <summary>
        /// 识别出的字段名称(关键字)。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 识别出的字段名称对应的值。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 置信度 0 ~100。
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 文本行在旋转纠正之后的图像中的像素
        /// 坐标。
        /// </summary>
        [JsonProperty("ItemCoord")]
        public ItemCoord ItemCoord{ get; set; }

        /// <summary>
        /// 字段所在行号，下标从0开始，非行字段或未能识别行号的该值返回-1。
        /// </summary>
        [JsonProperty("Row")]
        public long? Row{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamObj(map, prefix + "ItemCoord.", this.ItemCoord);
            this.SetParamSimple(map, prefix + "Row", this.Row);
        }
    }
}

