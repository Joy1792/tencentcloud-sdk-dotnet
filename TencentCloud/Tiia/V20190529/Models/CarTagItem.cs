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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CarTagItem : AbstractModel
    {
        
        /// <summary>
        /// 车系
        /// </summary>
        [JsonProperty("Serial")]
        public string Serial{ get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 车辆颜色
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 车系置信度，0-100
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 年份，没识别出年份的时候返回0
        /// </summary>
        [JsonProperty("Year")]
        public long? Year{ get; set; }

        /// <summary>
        /// 车辆在图片中的坐标信息
        /// </summary>
        [JsonProperty("CarLocation")]
        public Coord[] CarLocation{ get; set; }

        /// <summary>
        /// 车牌信息，仅车辆识别（增强版）支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlateContent")]
        public CarPlateContent PlateContent{ get; set; }

        /// <summary>
        /// 车牌信息置信度，0-100，仅车辆识别（增强版）支持
        /// </summary>
        [JsonProperty("PlateConfidence")]
        public long? PlateConfidence{ get; set; }

        /// <summary>
        /// 车辆类型置信度，0-100，仅车辆识别（增强版）支持
        /// </summary>
        [JsonProperty("TypeConfidence")]
        public long? TypeConfidence{ get; set; }

        /// <summary>
        /// 车辆颜色置信度，0-100，仅车辆识别（增强版）支持
        /// </summary>
        [JsonProperty("ColorConfidence")]
        public long? ColorConfidence{ get; set; }

        /// <summary>
        /// 车辆朝向，仅车辆识别（增强版）支持
        /// </summary>
        [JsonProperty("Orientation")]
        public string Orientation{ get; set; }

        /// <summary>
        /// 车辆朝向置信度，0-100，仅车辆识别（增强版）支持
        /// </summary>
        [JsonProperty("OrientationConfidence")]
        public long? OrientationConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Serial", this.Serial);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Year", this.Year);
            this.SetParamArrayObj(map, prefix + "CarLocation.", this.CarLocation);
            this.SetParamObj(map, prefix + "PlateContent.", this.PlateContent);
            this.SetParamSimple(map, prefix + "PlateConfidence", this.PlateConfidence);
            this.SetParamSimple(map, prefix + "TypeConfidence", this.TypeConfidence);
            this.SetParamSimple(map, prefix + "ColorConfidence", this.ColorConfidence);
            this.SetParamSimple(map, prefix + "Orientation", this.Orientation);
            this.SetParamSimple(map, prefix + "OrientationConfidence", this.OrientationConfidence);
        }
    }
}

