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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAuditResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否开启cmq消息通知。1：是，0：否。
        /// </summary>
        [JsonProperty("IsEnableCmqNotify")]
        public long? IsEnableCmqNotify{ get; set; }

        /// <summary>
        /// 管理事件读写属性，1：只读，2：只写，3：全部
        /// </summary>
        [JsonProperty("ReadWriteAttribute")]
        public long? ReadWriteAttribute{ get; set; }

        /// <summary>
        /// CMK的全局唯一标识符。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 跟踪集状态，1：开启，0：停止。
        /// </summary>
        [JsonProperty("AuditStatus")]
        public long? AuditStatus{ get; set; }

        /// <summary>
        /// 跟踪集名称。
        /// </summary>
        [JsonProperty("AuditName")]
        public string AuditName{ get; set; }

        /// <summary>
        /// cos存储桶所在地域。
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 队列名称。
        /// </summary>
        [JsonProperty("CmqQueueName")]
        public string CmqQueueName{ get; set; }

        /// <summary>
        /// CMK别名。
        /// </summary>
        [JsonProperty("KmsAlias")]
        public string KmsAlias{ get; set; }

        /// <summary>
        /// kms地域。
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }

        /// <summary>
        /// 是否开启kms加密。1：是，0：否。如果开启KMS加密，数据在投递到cos时，会将数据加密。
        /// </summary>
        [JsonProperty("IsEnableKmsEncry")]
        public long? IsEnableKmsEncry{ get; set; }

        /// <summary>
        /// cos存储桶名称。
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// 队列所在地域。
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// 日志前缀。
        /// </summary>
        [JsonProperty("LogFilePrefix")]
        public string LogFilePrefix{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsEnableCmqNotify", this.IsEnableCmqNotify);
            this.SetParamSimple(map, prefix + "ReadWriteAttribute", this.ReadWriteAttribute);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "AuditStatus", this.AuditStatus);
            this.SetParamSimple(map, prefix + "AuditName", this.AuditName);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "CmqQueueName", this.CmqQueueName);
            this.SetParamSimple(map, prefix + "KmsAlias", this.KmsAlias);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
            this.SetParamSimple(map, prefix + "IsEnableKmsEncry", this.IsEnableKmsEncry);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "LogFilePrefix", this.LogFilePrefix);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

