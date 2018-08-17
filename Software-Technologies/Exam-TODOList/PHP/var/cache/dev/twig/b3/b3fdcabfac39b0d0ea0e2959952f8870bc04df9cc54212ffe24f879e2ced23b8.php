<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_0ef46ff3e00be850b375145c4de69a72941605b1b30816a42d1a36aa92bc080f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_02580a804c10548a9563a7deb4a3a988d0b952da656d40e54cc25263ba68fdfa = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_02580a804c10548a9563a7deb4a3a988d0b952da656d40e54cc25263ba68fdfa->enter($__internal_02580a804c10548a9563a7deb4a3a988d0b952da656d40e54cc25263ba68fdfa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_2964eb61c0cd1f47d7968c2e201d16c9ee892cd8dc4c7285d4421837380f6eac = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2964eb61c0cd1f47d7968c2e201d16c9ee892cd8dc4c7285d4421837380f6eac->enter($__internal_2964eb61c0cd1f47d7968c2e201d16c9ee892cd8dc4c7285d4421837380f6eac_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_02580a804c10548a9563a7deb4a3a988d0b952da656d40e54cc25263ba68fdfa->leave($__internal_02580a804c10548a9563a7deb4a3a988d0b952da656d40e54cc25263ba68fdfa_prof);

        
        $__internal_2964eb61c0cd1f47d7968c2e201d16c9ee892cd8dc4c7285d4421837380f6eac->leave($__internal_2964eb61c0cd1f47d7968c2e201d16c9ee892cd8dc4c7285d4421837380f6eac_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_483651033e6df413ad352291523fed0545ee4bc8e0b2be0ef6fe3b7e42b85b3a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_483651033e6df413ad352291523fed0545ee4bc8e0b2be0ef6fe3b7e42b85b3a->enter($__internal_483651033e6df413ad352291523fed0545ee4bc8e0b2be0ef6fe3b7e42b85b3a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_5041b49a3c69e45b29799b1ac0a0829d3b7906b0be2745239ecf5895237a21dc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5041b49a3c69e45b29799b1ac0a0829d3b7906b0be2745239ecf5895237a21dc->enter($__internal_5041b49a3c69e45b29799b1ac0a0829d3b7906b0be2745239ecf5895237a21dc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_5041b49a3c69e45b29799b1ac0a0829d3b7906b0be2745239ecf5895237a21dc->leave($__internal_5041b49a3c69e45b29799b1ac0a0829d3b7906b0be2745239ecf5895237a21dc_prof);

        
        $__internal_483651033e6df413ad352291523fed0545ee4bc8e0b2be0ef6fe3b7e42b85b3a->leave($__internal_483651033e6df413ad352291523fed0545ee4bc8e0b2be0ef6fe3b7e42b85b3a_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_2723dd34997f6bd13481be06ee0e35ffa56910fe9ac8f6663a6137ba6d50a485 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2723dd34997f6bd13481be06ee0e35ffa56910fe9ac8f6663a6137ba6d50a485->enter($__internal_2723dd34997f6bd13481be06ee0e35ffa56910fe9ac8f6663a6137ba6d50a485_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_8febdde8a18496e8b75d008f88cf8eb43f94435b6a59caa3df3ffde4a2e84629 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8febdde8a18496e8b75d008f88cf8eb43f94435b6a59caa3df3ffde4a2e84629->enter($__internal_8febdde8a18496e8b75d008f88cf8eb43f94435b6a59caa3df3ffde4a2e84629_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_8febdde8a18496e8b75d008f88cf8eb43f94435b6a59caa3df3ffde4a2e84629->leave($__internal_8febdde8a18496e8b75d008f88cf8eb43f94435b6a59caa3df3ffde4a2e84629_prof);

        
        $__internal_2723dd34997f6bd13481be06ee0e35ffa56910fe9ac8f6663a6137ba6d50a485->leave($__internal_2723dd34997f6bd13481be06ee0e35ffa56910fe9ac8f6663a6137ba6d50a485_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_096bcf36db23622fc405750d2d81a58fba357ab954fff9c7c9bdb50168e2f03b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_096bcf36db23622fc405750d2d81a58fba357ab954fff9c7c9bdb50168e2f03b->enter($__internal_096bcf36db23622fc405750d2d81a58fba357ab954fff9c7c9bdb50168e2f03b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_3455267e48e8cb9de6f8afbb64eadbce2f1adc4838867aa6dc6f2c59a9381e06 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3455267e48e8cb9de6f8afbb64eadbce2f1adc4838867aa6dc6f2c59a9381e06->enter($__internal_3455267e48e8cb9de6f8afbb64eadbce2f1adc4838867aa6dc6f2c59a9381e06_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_3455267e48e8cb9de6f8afbb64eadbce2f1adc4838867aa6dc6f2c59a9381e06->leave($__internal_3455267e48e8cb9de6f8afbb64eadbce2f1adc4838867aa6dc6f2c59a9381e06_prof);

        
        $__internal_096bcf36db23622fc405750d2d81a58fba357ab954fff9c7c9bdb50168e2f03b->leave($__internal_096bcf36db23622fc405750d2d81a58fba357ab954fff9c7c9bdb50168e2f03b_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}
