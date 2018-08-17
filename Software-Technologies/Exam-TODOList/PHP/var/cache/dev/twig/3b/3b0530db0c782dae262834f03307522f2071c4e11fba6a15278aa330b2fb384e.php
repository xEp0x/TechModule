<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_971f8e4193fa28c89dc7c599605bf2d07a36324b85dd110cd4ce428862fd61ed = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_971f8e4193fa28c89dc7c599605bf2d07a36324b85dd110cd4ce428862fd61ed->enter($__internal_971f8e4193fa28c89dc7c599605bf2d07a36324b85dd110cd4ce428862fd61ed_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_7e3a88d19462747cc2a68dc98a1c432793a2876e541bd6d6eb1ed0ac7f3b0807 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7e3a88d19462747cc2a68dc98a1c432793a2876e541bd6d6eb1ed0ac7f3b0807->enter($__internal_7e3a88d19462747cc2a68dc98a1c432793a2876e541bd6d6eb1ed0ac7f3b0807_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_971f8e4193fa28c89dc7c599605bf2d07a36324b85dd110cd4ce428862fd61ed->leave($__internal_971f8e4193fa28c89dc7c599605bf2d07a36324b85dd110cd4ce428862fd61ed_prof);

        
        $__internal_7e3a88d19462747cc2a68dc98a1c432793a2876e541bd6d6eb1ed0ac7f3b0807->leave($__internal_7e3a88d19462747cc2a68dc98a1c432793a2876e541bd6d6eb1ed0ac7f3b0807_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_448e1a79136559ec1fbd3a28bce6451aebfc1426a88a49bc2acfa69464eb3bcd = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_448e1a79136559ec1fbd3a28bce6451aebfc1426a88a49bc2acfa69464eb3bcd->enter($__internal_448e1a79136559ec1fbd3a28bce6451aebfc1426a88a49bc2acfa69464eb3bcd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_db7b7bf19b5a806474ff6e2439bfeb88c27647db07bc480947552df05bff489a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_db7b7bf19b5a806474ff6e2439bfeb88c27647db07bc480947552df05bff489a->enter($__internal_db7b7bf19b5a806474ff6e2439bfeb88c27647db07bc480947552df05bff489a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_db7b7bf19b5a806474ff6e2439bfeb88c27647db07bc480947552df05bff489a->leave($__internal_db7b7bf19b5a806474ff6e2439bfeb88c27647db07bc480947552df05bff489a_prof);

        
        $__internal_448e1a79136559ec1fbd3a28bce6451aebfc1426a88a49bc2acfa69464eb3bcd->leave($__internal_448e1a79136559ec1fbd3a28bce6451aebfc1426a88a49bc2acfa69464eb3bcd_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_05a191451326d7f113e50b70965a014bbb3152d4e52587a3ca159a1ded2acea5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_05a191451326d7f113e50b70965a014bbb3152d4e52587a3ca159a1ded2acea5->enter($__internal_05a191451326d7f113e50b70965a014bbb3152d4e52587a3ca159a1ded2acea5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_429fd08deaacf7ee9f2ce10e8d7caf31d8ad379671cb5c0429c4ae001f685bbc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_429fd08deaacf7ee9f2ce10e8d7caf31d8ad379671cb5c0429c4ae001f685bbc->enter($__internal_429fd08deaacf7ee9f2ce10e8d7caf31d8ad379671cb5c0429c4ae001f685bbc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_429fd08deaacf7ee9f2ce10e8d7caf31d8ad379671cb5c0429c4ae001f685bbc->leave($__internal_429fd08deaacf7ee9f2ce10e8d7caf31d8ad379671cb5c0429c4ae001f685bbc_prof);

        
        $__internal_05a191451326d7f113e50b70965a014bbb3152d4e52587a3ca159a1ded2acea5->leave($__internal_05a191451326d7f113e50b70965a014bbb3152d4e52587a3ca159a1ded2acea5_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_91b4c32580b5bf55dc8db32ef2b05f753dead64809728d8e141efb3301bb846a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_91b4c32580b5bf55dc8db32ef2b05f753dead64809728d8e141efb3301bb846a->enter($__internal_91b4c32580b5bf55dc8db32ef2b05f753dead64809728d8e141efb3301bb846a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_b2ade58e26956b857f32a94261b4c3c8fa178a316987043ed887a1e85e8b0a66 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b2ade58e26956b857f32a94261b4c3c8fa178a316987043ed887a1e85e8b0a66->enter($__internal_b2ade58e26956b857f32a94261b4c3c8fa178a316987043ed887a1e85e8b0a66_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_b2ade58e26956b857f32a94261b4c3c8fa178a316987043ed887a1e85e8b0a66->leave($__internal_b2ade58e26956b857f32a94261b4c3c8fa178a316987043ed887a1e85e8b0a66_prof);

        
        $__internal_91b4c32580b5bf55dc8db32ef2b05f753dead64809728d8e141efb3301bb846a->leave($__internal_91b4c32580b5bf55dc8db32ef2b05f753dead64809728d8e141efb3301bb846a_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
