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

namespace TencentCloud.Facefusion.V20220927.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FuseFaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 活动 ID，请在<a href="https://console.cloud.tencent.com/facefusion" target="_blank">人脸融合控制台</a>查看。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 素材 ID，请在<a href="https://console.cloud.tencent.com/facefusion" target="_blank">人脸融合控制台</a>查看。
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 返回图像方式（url 或 base64) ，二选一。url有效期为7天。
        /// </summary>
        [JsonProperty("RspImgType")]
        public string RspImgType{ get; set; }

        /// <summary>
        /// 用户人脸图片、素材模板图的人脸位置信息。不能超过6个。
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
        /// 为融合结果图添加合成标识的开关，默认为1。
        /// 1：添加标识。
        /// 0：不添加标识。
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示结果图使用了人脸融合技术，是AI合成的图片。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在融合结果图右下角添加“本图片为AI合成图片”字样，您可根据自身需要替换为其他的Logo图片。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }

        /// <summary>
        /// 融合参数。
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
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
            this.SetParamObj(map, prefix + "FuseParam.", this.FuseParam);
        }
    }
}

