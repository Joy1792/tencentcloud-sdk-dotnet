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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhoneVerificationResponse : AbstractModel
    {
        
        /// <summary>
        /// 认证结果码。
        /// - 收费结果码
        /// 0: 三要素信息一致。
        /// -4: 三要素信息不一致。
        /// 
        /// - 不收费结果码
        /// -6: 手机号码不合法。
        /// -7: 身份证号码有误。
        /// -8: 姓名校验不通过。
        /// -9: 没有记录。
        /// -11: 验证中心服务繁忙。
        /// -12: 认证次数超过当日限制，请次日重试。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 业务结果描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 运营商名称。
        /// - 取值范围为["","移动","电信","联通"]
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// 业务结果详细信息。
        /// - 当VerifyMode配置"详版"，且Result为"-4: 三要素信息不一致"时返回。
        /// - 枚举值：
        /// PhoneIdCardMismatch：手机号码与姓名一致，与身份证号不一致。
        /// PhoneNameMismatch：手机号码身份证号一致，与姓名不一致。
        /// PhoneNameIdCardMismatch：手机号码与姓名和身份证号均不一致。
        /// NameIdCardMismatch：姓名和身份证号不一致。
        /// OtherMismatch：其他不一致。
        /// </summary>
        [JsonProperty("ResultDetail")]
        public string ResultDetail{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "ResultDetail", this.ResultDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

