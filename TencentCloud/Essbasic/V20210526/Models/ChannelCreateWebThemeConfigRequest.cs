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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCreateWebThemeConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 主题类型<br/>EMBED_WEB_THEME：嵌入式主题
        /// <ul>
        /// <li>EMBED_WEB_THEME，web页面嵌入的主题风格配置</li>
        /// <li>COMPANY_AUTHENTICATE，子客认证主题配置， 对当前第三方应用号生效，
        /// 目前支持的有，背景图替换，隐藏企业认证页面导航栏和隐藏企业认证顶部logo</li>
        /// </ul>
        /// </summary>
        [JsonProperty("ThemeType")]
        public string ThemeType{ get; set; }

        /// <summary>
        /// 主题配置
        /// </summary>
        [JsonProperty("WebThemeConfig")]
        public WebThemeConfig WebThemeConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ThemeType", this.ThemeType);
            this.SetParamObj(map, prefix + "WebThemeConfig.", this.WebThemeConfig);
        }
    }
}

