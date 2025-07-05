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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowTrigger : AbstractModel
    {
        
        /// <summary>
        /// 触发器的类型，可选值：
        /// <li>CosFileUpload：COS触发</li>
        /// <li>AwsS3FileUpload：AWS触发，目前只支持转码任务。只有编排支持，工作流不支持。  </li>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 当 Type 为 CosFileUpload 时必填且有效，为 COS 触发规则。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CosFileUploadTrigger")]
        public CosFileUploadTrigger CosFileUploadTrigger{ get; set; }

        /// <summary>
        /// 当 Type 为 AwsS3FileUpload 时必填且有效，为 AWS S3 触发规则。
        /// 
        /// 注意：目前AWS的S3、对应触发队列SQS、回调队列SQS的秘钥需要一致。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AwsS3FileUploadTrigger")]
        public AwsS3FileUploadTrigger AwsS3FileUploadTrigger{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CosFileUploadTrigger.", this.CosFileUploadTrigger);
            this.SetParamObj(map, prefix + "AwsS3FileUploadTrigger.", this.AwsS3FileUploadTrigger);
        }
    }
}

