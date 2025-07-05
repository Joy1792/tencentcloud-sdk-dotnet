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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskNotifyConfig : AbstractModel
    {
        
        /// <summary>
        /// 通知类型，可选值：
        /// <li>CMQ：已下线，建议切换到TDMQ-CMQ</li>
        /// <li>TDMQ-CMQ：消息队列</li>
        /// <li>URL：指定URL时HTTP回调推送到 NotifyUrl 指定的地址，回调协议http+json，包体内容同解析事件通知接口的输出参数 </li>
        /// <li>SCF：不推荐使用，需要在控制台额外配置SCF</li>
        /// <li>AWS-SQS：AWS 队列，只适用于 AWS 任务，且要求同区域</li>
        /// <font color="red"> 注：不填或为空时默认 CMQ，如需采用其他类型需填写对应类型值。 </font>
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 工作流通知的模式，可取值有 Finish 和 Change，不填代表 Finish。
        /// </summary>
        [JsonProperty("NotifyMode")]
        public string NotifyMode{ get; set; }

        /// <summary>
        /// HTTP回调地址，NotifyType为URL时必填。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// CMQ或TDMQ-CMQ 的模型，有 Queue 和 Topic 两种。
        /// </summary>
        [JsonProperty("CmqModel")]
        public string CmqModel{ get; set; }

        /// <summary>
        /// CMQ或TDMQ-CMQ 的园区，如 sh，bj 等。
        /// </summary>
        [JsonProperty("CmqRegion")]
        public string CmqRegion{ get; set; }

        /// <summary>
        /// 当模型为 Topic 时有效，表示接收事件通知的 CMQ 或 TDMQ-CMQ 的主题名。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 当模型为 Queue 时有效，表示接收事件通知的 CMQ 或 TDMQ-CMQ 的队列名。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// AWS SQS 回调，NotifyType为 AWS-SQS 时必填。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AwsSQS")]
        public AwsSQS AwsSQS{ get; set; }

        /// <summary>
        /// 用于生成回调签名的key。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotifyKey")]
        public string NotifyKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "NotifyMode", this.NotifyMode);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "CmqModel", this.CmqModel);
            this.SetParamSimple(map, prefix + "CmqRegion", this.CmqRegion);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamObj(map, prefix + "AwsSQS.", this.AwsSQS);
            this.SetParamSimple(map, prefix + "NotifyKey", this.NotifyKey);
        }
    }
}

