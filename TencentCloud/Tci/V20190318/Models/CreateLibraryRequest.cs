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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLibraryRequest : AbstractModel
    {
        
        /// <summary>
        /// 人员库名称
        /// </summary>
        [JsonProperty("LibraryName")]
        public string LibraryName{ get; set; }

        /// <summary>
        /// 人员库唯一标志符，为空则系统自动生成。
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LibraryName", this.LibraryName);
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
        }
    }
}

