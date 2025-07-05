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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExportJobResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 导出的状态。取值为, SUCCESS:成功、FAILURE:失败，RUNNING: 进行中。
        /// </summary>
        [JsonProperty("ExportStatus")]
        public string ExportStatus{ get; set; }

        /// <summary>
        /// 返回下载URL
        /// </summary>
        [JsonProperty("DownloadURL")]
        public string DownloadURL{ get; set; }

        /// <summary>
        /// 当ExportStatus为RUNNING时，返回导出进度。0~100范围的浮点数。
        /// </summary>
        [JsonProperty("ExportProgress")]
        public float? ExportProgress{ get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("FailureMsg")]
        public string FailureMsg{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExportStatus", this.ExportStatus);
            this.SetParamSimple(map, prefix + "DownloadURL", this.DownloadURL);
            this.SetParamSimple(map, prefix + "ExportProgress", this.ExportProgress);
            this.SetParamSimple(map, prefix + "FailureMsg", this.FailureMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

