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

    public class DescribePersonResponse : AbstractModel
    {
        
        /// <summary>
        /// 人员人脸列表
        /// </summary>
        [JsonProperty("FaceSet")]
        public Face[] FaceSet{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 工作号码
        /// </summary>
        [JsonProperty("JobNumber")]
        public string JobNumber{ get; set; }

        /// <summary>
        /// 人员库唯一标识符
        /// </summary>
        [JsonProperty("LibraryId")]
        public string LibraryId{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Male")]
        public long? Male{ get; set; }

        /// <summary>
        /// 人员唯一标识符
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        [JsonProperty("PersonName")]
        public string PersonName{ get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 学生号码
        /// </summary>
        [JsonProperty("StudentNumber")]
        public string StudentNumber{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FaceSet.", this.FaceSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "JobNumber", this.JobNumber);
            this.SetParamSimple(map, prefix + "LibraryId", this.LibraryId);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "Male", this.Male);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "PersonName", this.PersonName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "StudentNumber", this.StudentNumber);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

