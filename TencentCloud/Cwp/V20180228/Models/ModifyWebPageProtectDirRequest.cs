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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWebPageProtectDirRequest : AbstractModel
    {
        
        /// <summary>
        /// 网站防护目录地址
        /// </summary>
        [JsonProperty("ProtectDirAddr")]
        public string ProtectDirAddr{ get; set; }

        /// <summary>
        /// 网站防护目录名称
        /// </summary>
        [JsonProperty("ProtectDirName")]
        public string ProtectDirName{ get; set; }

        /// <summary>
        /// 防护文件类型,分号分割 ;
        /// </summary>
        [JsonProperty("ProtectFileType")]
        public string ProtectFileType{ get; set; }

        /// <summary>
        /// 防护机器列表信息
        /// </summary>
        [JsonProperty("HostConfig")]
        public ProtectHostConfig[] HostConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectDirAddr", this.ProtectDirAddr);
            this.SetParamSimple(map, prefix + "ProtectDirName", this.ProtectDirName);
            this.SetParamSimple(map, prefix + "ProtectFileType", this.ProtectFileType);
            this.SetParamArrayObj(map, prefix + "HostConfig.", this.HostConfig);
        }
    }
}

