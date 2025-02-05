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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlackEmailAddress : AbstractModel
    {
        
        /// <summary>
        /// 邮箱被拉黑时间
        /// </summary>
        [JsonProperty("BounceTime")]
        public string BounceTime{ get; set; }

        /// <summary>
        /// 被拉黑的邮箱地址
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 被拉黑的理由
        /// </summary>
        [JsonProperty("IspDesc")]
        public string IspDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BounceTime", this.BounceTime);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "IspDesc", this.IspDesc);
        }
    }
}

