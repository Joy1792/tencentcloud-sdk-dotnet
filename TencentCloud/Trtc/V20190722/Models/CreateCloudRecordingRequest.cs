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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudRecordingRequest : AbstractModel
    {
        
        /// <summary>
        /// TRTC的[SdkAppId](https://cloud.tencent.com/document/product/647/46351#sdkappid)，和录制的房间所对应的SdkAppId相同。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// TRTC的[RoomId](https://cloud.tencent.com/document/product/647/46351#roomid)，录制的TRTC房间所对应的RoomId。
        /// 注：房间号类型默认为整型，若房间号类型为字符串，请通过RoomIdType指定。
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 录制机器人的UserId，用于进房发起录制任务。
        /// 【*注意】这个UserId不能与当前房间内的主播观众[UserId](https://cloud.tencent.com/document/product/647/46351#userid)重复。如果一个房间发起多个录制任务时，机器人的userid也不能相互重复，否则会中断前一个录制任务。建议可以把房间ID作为UserId的标识的一部分，即录制机器人UserId在房间内唯一。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 录制机器人UserId对应的校验签名，即UserId和UserSig相当于录制机器人进房的登录密码，具体计算方法请参考TRTC计算[UserSig](https://cloud.tencent.com/document/product/647/45910#UserSig)的方案。
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// 云端录制控制参数。
        /// </summary>
        [JsonProperty("RecordParams")]
        public RecordParams RecordParams{ get; set; }

        /// <summary>
        /// 云端录制文件上传到云存储的参数（不支持同时设置云点播VOD和对象存储COS）
        /// </summary>
        [JsonProperty("StorageParams")]
        public StorageParams StorageParams{ get; set; }

        /// <summary>
        /// TRTC房间号的类型。
        /// 【*注意】必须和录制的房间所对应的RoomId类型相同:
        /// 0: 字符串类型的RoomId
        /// 1: 32位整型的RoomId（默认）
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// 合流的转码参数，录制模式为合流的时候可以设置。
        /// </summary>
        [JsonProperty("MixTranscodeParams")]
        public MixTranscodeParams MixTranscodeParams{ get; set; }

        /// <summary>
        /// 合流的布局参数，录制模式为合流的时候可以设置。
        /// </summary>
        [JsonProperty("MixLayoutParams")]
        public MixLayoutParams MixLayoutParams{ get; set; }

        /// <summary>
        /// 接口可以调用的时效性，从成功开启录制并获得任务ID后开始计算，超时后无法调用查询、更新和停止等接口，但是录制任务不会停止。 参数的单位是小时，默认72小时（3天），最大可设置720小时（30天），最小设置6小时。举例说明：如果不设置该参数，那么开始录制成功后，查询、更新和停止录制的调用时效为72个小时。
        /// </summary>
        [JsonProperty("ResourceExpiredHour")]
        public ulong? ResourceExpiredHour{ get; set; }

        /// <summary>
        /// TRTC房间权限加密串，只有在TRTC控制台启用了高级权限控制的时候需要携带，在TRTC控制台如果开启高级权限控制后，TRTC 的后台服务系统会校验一个叫做 [PrivateMapKey] 的“权限票据”，权限票据中包含了一个加密后的 RoomId 和一个加密后的“权限位列表”。由于 PrivateMapKey 中包含 RoomId，所以只提供了 UserSig 没有提供 PrivateMapKey 时，并不能进入指定的房间。
        /// </summary>
        [JsonProperty("PrivateMapKey")]
        public string PrivateMapKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamObj(map, prefix + "RecordParams.", this.RecordParams);
            this.SetParamObj(map, prefix + "StorageParams.", this.StorageParams);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamObj(map, prefix + "MixTranscodeParams.", this.MixTranscodeParams);
            this.SetParamObj(map, prefix + "MixLayoutParams.", this.MixLayoutParams);
            this.SetParamSimple(map, prefix + "ResourceExpiredHour", this.ResourceExpiredHour);
            this.SetParamSimple(map, prefix + "PrivateMapKey", this.PrivateMapKey);
        }
    }
}

