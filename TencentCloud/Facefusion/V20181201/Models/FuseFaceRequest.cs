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

namespace TencentCloud.Facefusion.V20181201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FuseFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 活动 ID，请在人脸融合控制台查看。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 素材 ID，请在人脸融合控制台查看。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 返回图像方式（url 或 base64) ，二选一。url有效期为7天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 用户人脸图片、素材模板图的人脸位置信息。
        /// </summary>
        [JsonProperty("MergeInfos")]
        public MergeInfo[] MergeInfos{ get; set; }

        /// <summary>
        /// 脸型融合比例，数值越高，融合后的脸型越像素材人物。取值范围[0,100] 
        /// 若此参数不填写，则使用人脸融合控制台中脸型参数数值。（换脸版算法暂不支持此参数调整）
        /// </summary>
        [JsonProperty("FuseProfileDegree")]
        public long? FuseProfileDegree{ get; set; }

        /// <summary>
        /// 五官融合比例，数值越高，融合后的五官越像素材人物。取值范围[0,100] 
        /// 若此参数不填写，则使用人脸融合控制台中五官参数数值。（换脸版算法暂不支持此参数调整）
        /// </summary>
        [JsonProperty("FuseFaceDegree")]
        public long? FuseFaceDegree{ get; set; }

        /// <summary>
        /// 0表示不需要不适宜内容识别，1表示需要不适宜内容识别。默认值为0。
        /// 请注意，不适宜内容识别服务开启后，您需要根据返回结果自行判断是否调整您的业务逻辑。例如提示您的用户图片非法，请更换图片。
        /// </summary>
        [JsonProperty("CelebrityIdentify")]
        public long? CelebrityIdentify{ get; set; }

        /// <summary>
        /// 融合参数
        /// </summary>
        [JsonProperty("FuseParam")]
        public FuseParam FuseParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "RspImgType", this.RspImgType);
            this.SetParamArrayObj(map, prefix + "MergeInfos.", this.MergeInfos);
            this.SetParamSimple(map, prefix + "FuseProfileDegree", this.FuseProfileDegree);
            this.SetParamSimple(map, prefix + "FuseFaceDegree", this.FuseFaceDegree);
            this.SetParamSimple(map, prefix + "CelebrityIdentify", this.CelebrityIdentify);
            this.SetParamObj(map, prefix + "FuseParam.", this.FuseParam);
        }
    }
}

