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

    public class WebThemeConfig : AbstractModel
    {
        
        /// <summary>
        /// 是否显示页面底部电子签logo，取值如下：
        /// <ul><li> **true**：页面底部显示电子签logo</li>
        /// <li> **false**：页面底部不显示电子签logo（默认）</li></ul>
        /// </summary>
        [JsonProperty("DisplaySignBrandLogo")]
        public bool? DisplaySignBrandLogo{ get; set; }

        /// <summary>
        /// 主题颜色：
        /// 支持十六进制颜色值以及RGB格式颜色值，例如：#D54941，rgb(213, 73, 65)
        /// <br/>
        /// </summary>
        [JsonProperty("WebEmbedThemeColor")]
        public string WebEmbedThemeColor{ get; set; }

        /// <summary>
        /// 企业认证页背景图（base64图片）
        /// </summary>
        [JsonProperty("AuthenticateBackground")]
        public string AuthenticateBackground{ get; set; }

        /// <summary>
        /// 隐藏企业认证页面导航栏，取值如下：
        /// <ul><li> **true**：隐藏企业认证页面导航栏</li>
        /// <li> **false**：显示企业认证页面导航栏（默认）</li></ul>
        /// </summary>
        [JsonProperty("HideAuthenticateNavigationBar")]
        public bool? HideAuthenticateNavigationBar{ get; set; }

        /// <summary>
        /// 隐藏企业认证顶部logo，取值如下：
        /// <ul><li> **true**：隐藏企业认证顶部logo</li>
        /// <li> **false**：显示企业认证顶部logo（默认）</li></ul>
        /// </summary>
        [JsonProperty("HideAuthenticateTopLogo")]
        public bool? HideAuthenticateTopLogo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisplaySignBrandLogo", this.DisplaySignBrandLogo);
            this.SetParamSimple(map, prefix + "WebEmbedThemeColor", this.WebEmbedThemeColor);
            this.SetParamSimple(map, prefix + "AuthenticateBackground", this.AuthenticateBackground);
            this.SetParamSimple(map, prefix + "HideAuthenticateNavigationBar", this.HideAuthenticateNavigationBar);
            this.SetParamSimple(map, prefix + "HideAuthenticateTopLogo", this.HideAuthenticateTopLogo);
        }
    }
}

