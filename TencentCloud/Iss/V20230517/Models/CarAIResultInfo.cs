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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CarAIResultInfo : AbstractModel
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
        /// 置信度，0 - 100
        /// </summary>
        [JsonProperty("Confidence")]
        public long? Confidence{ get; set; }

        /// <summary>
        /// 年份，识别不出年份时返回0
        /// </summary>
        [JsonProperty("Year")]
        public long? Year{ get; set; }

        /// <summary>
        /// 车牌信息
        /// </summary>
        [JsonProperty("PlateContent")]
        public PlateContent PlateContent{ get; set; }

        /// <summary>
        /// 截图中坐标信息
        /// </summary>
        [JsonProperty("Location")]
        public Location Location{ get; set; }


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
            this.SetParamObj(map, prefix + "PlateContent.", this.PlateContent);
            this.SetParamObj(map, prefix + "Location.", this.Location);
        }
    }
}

