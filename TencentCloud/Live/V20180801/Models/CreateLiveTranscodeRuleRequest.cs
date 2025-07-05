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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveTranscodeRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 播放域名。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 推流路径，与推流和播放地址中的AppName保持一致。如果只绑定域名，则此处填""。
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 流名称。已废弃该字段，请传入空字符串。
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 指定已有的模板Id。
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

