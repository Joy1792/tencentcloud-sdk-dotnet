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

namespace TencentCloud.Ecc.V20181213.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EHOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片所在的url或base64编码后的图像数据，依据InputType而定
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// 输出图片类型，0 表示 Image 字段是图片所在的 url，1 表示 Image 字段是 base64 编码后的图像数据
        /// </summary>
        [JsonProperty("InputType")]
        public long? InputType{ get; set; }

        /// <summary>
        /// 业务应用ID，与账号应用APPID无关，是用来方便客户管理服务的参数（暂时无需传入）。
        /// </summary>
        [JsonProperty("EccAppid")]
        public string EccAppid{ get; set; }

        /// <summary>
        /// 图像识别唯一标识，一次识别一个 SessionId，使用识别功能时 SessionId 可用于使用文本批改接口，此时按图像批改价格收费；如使用文本批改接口时没有传入 SessionId，则需要收取文本批改的费用
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 服务类型，0：“图像识别”，只返回识别结果，1：“图像批改”，同时返回识别结果与批改结果。默认为 0
        /// </summary>
        [JsonProperty("ServerType")]
        public long? ServerType{ get; set; }

        /// <summary>
        /// 作文题目，可选参数
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 年级标准， 默认以 cet4 为标准，取值与意义如下：elementary 小学，grade7 grade8 grade9分别对应初一，初二，初三。 grade10 grade11 grade12 分别对应高一，高二，高三，以及 cet4 和 cet6 分别表示 英语4级和6级。
        /// </summary>
        [JsonProperty("Grade")]
        public string Grade{ get; set; }

        /// <summary>
        /// 作文提纲，可选参数，作文的写作要求。
        /// </summary>
        [JsonProperty("Requirement")]
        public string Requirement{ get; set; }

        /// <summary>
        /// 范文标题，可选参数，本接口可以依据提供的范文对作文进行评分。
        /// </summary>
        [JsonProperty("ModelTitle")]
        public string ModelTitle{ get; set; }

        /// <summary>
        /// 范文内容，可选参数，同上，范文的正文部分。
        /// </summary>
        [JsonProperty("ModelContent")]
        public string ModelContent{ get; set; }

        /// <summary>
        /// 异步模式标识，0：同步模式，1：异步模式。默认为同步模式
        /// </summary>
        [JsonProperty("IsAsync")]
        public long? IsAsync{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "EccAppid", this.EccAppid);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "Grade", this.Grade);
            this.SetParamSimple(map, prefix + "Requirement", this.Requirement);
            this.SetParamSimple(map, prefix + "ModelTitle", this.ModelTitle);
            this.SetParamSimple(map, prefix + "ModelContent", this.ModelContent);
            this.SetParamSimple(map, prefix + "IsAsync", this.IsAsync);
        }
    }
}

