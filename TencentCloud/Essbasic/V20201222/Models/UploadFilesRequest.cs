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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 文件对应业务类型，用于区分文件存储路径：
        /// 1. TEMPLATE - 模版； 文件类型：.pdf/.html
        /// 2. DOCUMENT - 签署过程及签署后的合同文档 文件类型：.pdf/.html
        /// 3. FLOW - 签署过程 文件类型：.pdf/.html
        /// 4. SEAL - 印章； 文件类型：.jpg/.jpeg/.png
        /// 5. BUSINESSLICENSE - 营业执照 文件类型：.jpg/.jpeg/.png
        /// 6. IDCARD - 身份证 文件类型：.jpg/.jpeg/.png
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// 上传文件内容数组，最多支持20个文件
        /// </summary>
        [JsonProperty("FileInfos")]
        public UploadFile[] FileInfos{ get; set; }

        /// <summary>
        /// 上传文件链接数组，最多支持20个URL
        /// </summary>
        [JsonProperty("FileUrls")]
        public string[] FileUrls{ get; set; }

        /// <summary>
        /// 是否将pdf灰色矩阵置白
        /// true--是，处理置白
        /// false--否，不处理
        /// </summary>
        [JsonProperty("CoverRect")]
        public bool? CoverRect{ get; set; }

        /// <summary>
        /// 特殊文件类型需要指定文件类型：
        /// HTML-- .html文件
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 用户自定义ID数组，与上传文件一一对应
        /// </summary>
        [JsonProperty("CustomIds")]
        public string[] CustomIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArraySimple(map, prefix + "FileUrls.", this.FileUrls);
            this.SetParamSimple(map, prefix + "CoverRect", this.CoverRect);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "CustomIds.", this.CustomIds);
        }
    }
}

