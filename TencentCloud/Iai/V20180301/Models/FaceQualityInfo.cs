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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceQualityInfo : AbstractModel
    {
        
        /// <summary>
        /// 质量分: [0,100]，综合评价图像质量是否适合人脸识别，分数越高质量越好。 
        /// 正常情况，只需要使用Score作为质量分总体的判断标准即可。Sharpness、Brightness、Completeness等细项分仅供参考。
        /// 参考范围：[0,40]较差，[40,60] 一般，[60,80]较好，[80,100]很好。 
        /// 建议：人脸入库选取70以上的图片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 清晰分：[0,100]，评价图片清晰程度，分数越高越清晰。 
        /// 参考范围：[0,40]特别模糊，[40,60]模糊，[60,80]一般，[80,100]清晰。 
        /// 建议：人脸入库选取80以上的图片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sharpness")]
        public long? Sharpness{ get; set; }

        /// <summary>
        /// 光照分：[0,100]，评价图片光照程度，分数越高越亮。 
        /// 参考范围： [0,30]偏暗，[30,70]光照正常，[70,100]偏亮。 
        /// 建议：人脸入库选取[30,70]的图片。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Brightness")]
        public long? Brightness{ get; set; }

        /// <summary>
        /// 五官遮挡分，评价眉毛（Eyebrow）、眼睛（Eye）、鼻子（Nose）、脸颊（Cheek）、嘴巴（Mouth）、下巴（Chin）的被遮挡程度。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Completeness")]
        public FaceQualityCompleteness Completeness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Sharpness", this.Sharpness);
            this.SetParamSimple(map, prefix + "Brightness", this.Brightness);
            this.SetParamObj(map, prefix + "Completeness.", this.Completeness);
        }
    }
}

