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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadContentRequest : AbstractModel
    {
        
        /// <summary>
        /// 脚本上传信息
        /// </summary>
        [JsonProperty("ScriptRequestInfo")]
        public ScriptRequestInfo ScriptRequestInfo{ get; set; }

        /// <summary>
        /// 请求来源，WEB 前端；CLIENT 客户端
        /// </summary>
        [JsonProperty("RequestFromSource")]
        public string RequestFromSource{ get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ScriptRequestInfo.", this.ScriptRequestInfo);
            this.SetParamSimple(map, prefix + "RequestFromSource", this.RequestFromSource);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

