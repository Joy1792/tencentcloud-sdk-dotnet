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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MaterialStatus : AbstractModel
    {
        
        /// <summary>
        /// 素材编辑可用状态，取值有：
        /// <li>NORMAL：正常，可直接用于编辑；</li>
        /// <li>ABNORMAL : 异常，不可用于编辑；</li>
        /// <li>PROCESSING：处理中，暂不可用于编辑。</li>
        /// </summary>
        [JsonProperty("EditorUsableStatus")]
        public string EditorUsableStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EditorUsableStatus", this.EditorUsableStatus);
        }
    }
}

