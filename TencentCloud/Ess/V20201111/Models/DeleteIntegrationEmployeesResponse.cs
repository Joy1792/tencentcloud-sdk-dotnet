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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteIntegrationEmployeesResponse : AbstractModel
    {
        
        /// <summary>
        /// 员工删除结果。包含成功数据与失败数据。
        /// <ul><li>**成功数据**：展示员工姓名、手机号与电子签平台UserId</li>
        /// <li>**失败数据**：展示员工电子签平台UserId、第三方平台OpenId和失败原因</li></ul>
        /// </summary>
        [JsonProperty("DeleteEmployeeResult")]
        public DeleteStaffsResult DeleteEmployeeResult{ get; set; }

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
            this.SetParamObj(map, prefix + "DeleteEmployeeResult.", this.DeleteEmployeeResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

