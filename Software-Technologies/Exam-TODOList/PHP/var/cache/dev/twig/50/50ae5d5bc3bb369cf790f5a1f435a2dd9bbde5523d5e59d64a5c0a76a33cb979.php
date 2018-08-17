<?php

/* task/create.html.twig */
class __TwigTemplate_6e5eea0179c0e14d539c7b4381c84bf8b9ace588f2b99ef32d8733d57eb34b9a extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "task/create.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_d58ebc2ce6963ad7bfcaf95a8f313d79071c60b984e16e8ff83f8f802cc02787 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d58ebc2ce6963ad7bfcaf95a8f313d79071c60b984e16e8ff83f8f802cc02787->enter($__internal_d58ebc2ce6963ad7bfcaf95a8f313d79071c60b984e16e8ff83f8f802cc02787_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "task/create.html.twig"));

        $__internal_00c374b7ae5d1f961528c1ac3e0d8b5131e8deab6199d0a4226b63d80d7430e5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_00c374b7ae5d1f961528c1ac3e0d8b5131e8deab6199d0a4226b63d80d7430e5->enter($__internal_00c374b7ae5d1f961528c1ac3e0d8b5131e8deab6199d0a4226b63d80d7430e5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "task/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_d58ebc2ce6963ad7bfcaf95a8f313d79071c60b984e16e8ff83f8f802cc02787->leave($__internal_d58ebc2ce6963ad7bfcaf95a8f313d79071c60b984e16e8ff83f8f802cc02787_prof);

        
        $__internal_00c374b7ae5d1f961528c1ac3e0d8b5131e8deab6199d0a4226b63d80d7430e5->leave($__internal_00c374b7ae5d1f961528c1ac3e0d8b5131e8deab6199d0a4226b63d80d7430e5_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_532bf7a0e98946366a8b57a935eb1a8b252e9123a03813ef98ffd16f07798f8e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_532bf7a0e98946366a8b57a935eb1a8b252e9123a03813ef98ffd16f07798f8e->enter($__internal_532bf7a0e98946366a8b57a935eb1a8b252e9123a03813ef98ffd16f07798f8e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_5d83710701266de0fde12726e1c19fa06a018b7a64153fb1a51adc55caa9eee7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5d83710701266de0fde12726e1c19fa06a018b7a64153fb1a51adc55caa9eee7->enter($__internal_5d83710701266de0fde12726e1c19fa06a018b7a64153fb1a51adc55caa9eee7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "    <div id=\"create-wrapper\">
        <section class=\"create\">
            <article>
                <form action=\"";
        // line 7
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("create");
        echo "\" method=\"POST\">
                    <div class=\"row\">
                        <label for=\"task\">Task:</label>
                        <input type=\"text\" id=\"task\" name=\"task[title]\">
                    </div>
                    <div class=\"row\">
                        <label for=\"comments\">Comments:</label>
                        <textarea id=\"comments\" name=\"task[comments]\"></textarea>
                    </div>

                    ";
        // line 17
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "

                    <button type=\"submit\">Create</button>
                </form>
            </article>
        </section>
    </div>
";
        
        $__internal_5d83710701266de0fde12726e1c19fa06a018b7a64153fb1a51adc55caa9eee7->leave($__internal_5d83710701266de0fde12726e1c19fa06a018b7a64153fb1a51adc55caa9eee7_prof);

        
        $__internal_532bf7a0e98946366a8b57a935eb1a8b252e9123a03813ef98ffd16f07798f8e->leave($__internal_532bf7a0e98946366a8b57a935eb1a8b252e9123a03813ef98ffd16f07798f8e_prof);

    }

    public function getTemplateName()
    {
        return "task/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  67 => 17,  54 => 7,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
    <div id=\"create-wrapper\">
        <section class=\"create\">
            <article>
                <form action=\"{{ path('create') }}\" method=\"POST\">
                    <div class=\"row\">
                        <label for=\"task\">Task:</label>
                        <input type=\"text\" id=\"task\" name=\"task[title]\">
                    </div>
                    <div class=\"row\">
                        <label for=\"comments\">Comments:</label>
                        <textarea id=\"comments\" name=\"task[comments]\"></textarea>
                    </div>

                    {{ form_row(form._token) }}

                    <button type=\"submit\">Create</button>
                </form>
            </article>
        </section>
    </div>
{% endblock %}", "task/create.html.twig", "D:\\PROJECTS\\Software Technologies\\17. ExamPreparationI\\PHP Skeleton\\app\\Resources\\views\\task\\create.html.twig");
    }
}
