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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GooseFSxOptionOverview : AbstractModel
    {
        
        /// <summary>
        /// 文件系统master的ip和端口列表。
        /// </summary>
        [JsonProperty("Masters")]
        public string[] Masters{ get; set; }

        /// <summary>
        /// 文件系统的本地挂载路径。GooseFSx目前只支持挂载在/goosefsx/{文件系统ID}_proxy/目录下。
        /// </summary>
        [JsonProperty("LocalPath")]
        public string LocalPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Masters.", this.Masters);
            this.SetParamSimple(map, prefix + "LocalPath", this.LocalPath);
        }
    }
}

