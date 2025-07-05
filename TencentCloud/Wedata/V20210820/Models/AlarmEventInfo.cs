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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmEventInfo : AbstractModel
    {
        
        /// <summary>
        /// 告警ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 告警时间
        /// </summary>
        [JsonProperty("AlarmTime")]
        public string AlarmTime{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RegularName")]
        public string RegularName{ get; set; }

        /// <summary>
        /// 告警级别,0表示普通，1表示重要，2表示紧急
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// 告警方式,多个用逗号隔开（1:邮件，2:短信，3:微信，4:语音，5:代表企业微信，6:http）
        /// </summary>
        [JsonProperty("AlarmWay")]
        public ulong? AlarmWay{ get; set; }

        /// <summary>
        /// 告警接收人Id，多个用逗号隔开
        /// </summary>
        [JsonProperty("AlarmRecipientId")]
        public string AlarmRecipientId{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 告警指标,0表示任务失败，1表示任务运行超时，2表示任务停止，3表示任务暂停
        /// </summary>
        [JsonProperty("AlarmIndicator")]
        public ulong? AlarmIndicator{ get; set; }

        /// <summary>
        /// 告警指标描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmIndicatorDesc")]
        public string AlarmIndicatorDesc{ get; set; }

        /// <summary>
        /// 指标阈值，1表示离线任务第一次运行失败，2表示离线任务所有重试完成后失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// 预计的超时时间，分钟级别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EstimatedTime")]
        public ulong? EstimatedTime{ get; set; }

        /// <summary>
        /// 实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 0：部分成功，1：全部成功，2：全部失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSendSuccess")]
        public ulong? IsSendSuccess{ get; set; }

        /// <summary>
        /// 是否在免打扰时间内，0:否, 1:是
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InQuitePeriods")]
        public ulong? InQuitePeriods{ get; set; }

        /// <summary>
        /// 告警记录id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordId")]
        public ulong? RecordId{ get; set; }

        /// <summary>
        /// 消息ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// 阈值计算算子，1 : 大于 2 ：小于
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Operator")]
        public long? Operator{ get; set; }

        /// <summary>
        /// 告警规则ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegularId")]
        public string RegularId{ get; set; }

        /// <summary>
        /// 告警接收人昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmRecipientName")]
        public string AlarmRecipientName{ get; set; }

        /// <summary>
        /// 告警任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }

        /// <summary>
        /// 发送结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendResult")]
        public string SendResult{ get; set; }

        /// <summary>
        /// 监控对象id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorObjectId")]
        public string MonitorObjectId{ get; set; }

        /// <summary>
        /// 监控对象名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorObjectName")]
        public string MonitorObjectName{ get; set; }

        /// <summary>
        /// 指标阈值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Threshold")]
        public float? Threshold{ get; set; }

        /// <summary>
        /// 告警原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmReason")]
        public string AlarmReason{ get; set; }

        /// <summary>
        /// 近范围值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorTimeRangeValue")]
        public long? IndicatorTimeRangeValue{ get; set; }

        /// <summary>
        /// 近范围单位
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndicatorTimeRangeUnit")]
        public string IndicatorTimeRangeUnit{ get; set; }

        /// <summary>
        /// 同步类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyncType")]
        public long? SyncType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "AlarmTime", this.AlarmTime);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "RegularName", this.RegularName);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmWay", this.AlarmWay);
            this.SetParamSimple(map, prefix + "AlarmRecipientId", this.AlarmRecipientId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AlarmIndicator", this.AlarmIndicator);
            this.SetParamSimple(map, prefix + "AlarmIndicatorDesc", this.AlarmIndicatorDesc);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "EstimatedTime", this.EstimatedTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "IsSendSuccess", this.IsSendSuccess);
            this.SetParamSimple(map, prefix + "InQuitePeriods", this.InQuitePeriods);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RegularId", this.RegularId);
            this.SetParamSimple(map, prefix + "AlarmRecipientName", this.AlarmRecipientName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "SendResult", this.SendResult);
            this.SetParamSimple(map, prefix + "MonitorObjectId", this.MonitorObjectId);
            this.SetParamSimple(map, prefix + "MonitorObjectName", this.MonitorObjectName);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "AlarmReason", this.AlarmReason);
            this.SetParamSimple(map, prefix + "IndicatorTimeRangeValue", this.IndicatorTimeRangeValue);
            this.SetParamSimple(map, prefix + "IndicatorTimeRangeUnit", this.IndicatorTimeRangeUnit);
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
        }
    }
}

