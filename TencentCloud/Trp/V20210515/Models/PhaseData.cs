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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhaseData : AbstractModel
    {
        
        /// <summary>
        /// 启用头
        /// </summary>
        [JsonProperty("HeadEnabled")]
        public bool? HeadEnabled{ get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("HeadTitle")]
        public string HeadTitle{ get; set; }

        /// <summary>
        /// 标识符
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 小程序AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 小程序AppPath
        /// </summary>
        [JsonProperty("AppPath")]
        public string AppPath{ get; set; }

        /// <summary>
        /// 小程序名称AppName
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeadEnabled", this.HeadEnabled);
            this.SetParamSimple(map, prefix + "HeadTitle", this.HeadTitle);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AppPath", this.AppPath);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
        }
    }
}

