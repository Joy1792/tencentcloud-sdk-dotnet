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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageData : AbstractModel
    {
        
        /// <summary>
        /// 恶意类型
        /// 100：正常 
        /// 20001：政治
        /// 20002：色情 
        /// 20006：涉毒违法
        /// 20007：谩骂 
        /// 20103：性感
        /// 24001：暴恐
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 图片性感详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HotDetect")]
        public ImageHotDetect HotDetect{ get; set; }

        /// <summary>
        /// 是否恶意 0：正常 1：可疑
        /// </summary>
        [JsonProperty("EvilFlag")]
        public long? EvilFlag{ get; set; }

        /// <summary>
        /// 图片二维码详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeDetect")]
        public CodeDetect CodeDetect{ get; set; }

        /// <summary>
        /// 图片涉政详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolityDetect")]
        public ImagePolityDetect PolityDetect{ get; set; }

        /// <summary>
        /// 图片违法详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IllegalDetect")]
        public ImageIllegalDetect IllegalDetect{ get; set; }

        /// <summary>
        /// 图片涉黄详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PornDetect")]
        public ImagePornDetect PornDetect{ get; set; }

        /// <summary>
        /// 图片暴恐详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TerrorDetect")]
        public ImageTerrorDetect TerrorDetect{ get; set; }

        /// <summary>
        /// 图片OCR详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OCRDetect")]
        public OCRDetect OCRDetect{ get; set; }

        /// <summary>
        /// logo详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogoDetect")]
        public LogoDetail LogoDetect{ get; set; }

        /// <summary>
        /// 图片相似度详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Similar")]
        public Similar Similar{ get; set; }

        /// <summary>
        /// 手机检测详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneDetect")]
        public PhoneDetect PhoneDetect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamObj(map, prefix + "HotDetect.", this.HotDetect);
            this.SetParamSimple(map, prefix + "EvilFlag", this.EvilFlag);
            this.SetParamObj(map, prefix + "CodeDetect.", this.CodeDetect);
            this.SetParamObj(map, prefix + "PolityDetect.", this.PolityDetect);
            this.SetParamObj(map, prefix + "IllegalDetect.", this.IllegalDetect);
            this.SetParamObj(map, prefix + "PornDetect.", this.PornDetect);
            this.SetParamObj(map, prefix + "TerrorDetect.", this.TerrorDetect);
            this.SetParamObj(map, prefix + "OCRDetect.", this.OCRDetect);
            this.SetParamObj(map, prefix + "LogoDetect.", this.LogoDetect);
            this.SetParamObj(map, prefix + "Similar.", this.Similar);
            this.SetParamObj(map, prefix + "PhoneDetect.", this.PhoneDetect);
        }
    }
}

