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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNotificationConfigurationRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。可通过登录 [控制台](https://console.cloud.tencent.com/autoscaling/group) 或调用接口 [DescribeAutoScalingGroups](https://cloud.tencent.com/document/api/377/20438) ，取返回信息中的 AutoScalingGroupId 获取伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 通知类型，即为需要订阅的通知类型集合，取值范围如下：
        /// <li>SCALE_OUT_SUCCESSFUL：扩容成功</li>
        /// <li>SCALE_OUT_FAILED：扩容失败</li>
        /// <li>SCALE_IN_SUCCESSFUL：缩容成功</li>
        /// <li>SCALE_IN_FAILED：缩容失败</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL：替换不健康子机成功</li>
        /// <li>REPLACE_UNHEALTHY_INSTANCE_FAILED：替换不健康子机失败</li>
        /// </summary>
        [JsonProperty("NotificationTypes")]
        public string[] NotificationTypes{ get; set; }

        /// <summary>
        /// 通知组ID，即为用户组ID集合，用户组ID可以通过[ListGroups](https://cloud.tencent.com/document/product/598/34589)查询。该参数仅在 TargetType 为 USER_GROUP 时生效。
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }

        /// <summary>
        /// 通知接收端类型，取值如下：
        /// <li>USER_GROUP：用户组</li>
        /// <li>TDMQ_CMQ_TOPIC：TDMQ CMQ 主题</li>
        /// <li>TDMQ_CMQ_QUEUE：TDMQ CMQ 队列</li>
        /// <li>CMQ_QUEUE：CMQ 队列，[CMQ已下线](https://cloud.tencent.com/document/product/1496/83970)，目前仅推荐使用  TDMQ CMQ。</li>
        /// <li>CMQ_TOPIC：CMQ 主题，[CMQ已下线](https://cloud.tencent.com/document/product/1496/83970)，目前仅推荐使用  TDMQ CMQ。</li>
        /// 
        /// 默认值为：`USER_GROUP`。
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// TDMQ CMQ 队列名，如 TargetType 取值为 `TDMQ_CMQ_QUEUE` ，该字段必填。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// TDMQ CMQ 主题名，如 TargetType 取值为 `TDMQ_CMQ_TOPIC` ，该字段必填。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamArraySimple(map, prefix + "NotificationTypes.", this.NotificationTypes);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

